using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class CourseManageForm : Form
    {
        CourseClass cc = new CourseClass();
        DBconnect connect = new DBconnect();
        private bool isPlaceholderActive = true; // To track placeholder status

        public CourseManageForm()
        {
            InitializeComponent();
            dataGridView_manage_course.RowHeadersVisible = false;
            dataGridView_manage_course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CourseManageForm_Load(object sender, EventArgs e)
        {
            showdata();
            fillCourseCombo();
            SetupComboBoxPlaceholder();
        }

        private void showdata()
        {
            // To show course list on datagridview
            dataGridView_manage_course.DataSource = cc.getCourse(new SqlCommand("SELECT * FROM Courses"));
        }

        // Method to load course IDs into the combobox
        public void fillCourseCombo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT CourseId FROM Courses", connect.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBox_id.DataSource = table;
                comboBox_id.DisplayMember = "CourseId";
                comboBox_id.ValueMember = "CourseId";
                comboBox_id.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to set placeholder in the combobox
        private void SetupComboBoxPlaceholder()
        {
            comboBox_id.Text = "Search by Course Id";
            comboBox_id.ForeColor = Color.Gray;

            comboBox_id.Enter += ComboBox_id_Enter;
            comboBox_id.Leave += ComboBox_id_Leave;
        }

        // Clear text when clicking or focusing on the combobox
        private void ComboBox_id_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                comboBox_id.Text = "";
                comboBox_id.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        // Restore placeholder if combobox loses focus and remains empty
        private void ComboBox_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                isPlaceholderActive = true;
                comboBox_id.Text = "Search by Course Id";
                comboBox_id.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBox_coursename.Clear();
            textBox2_hour.Clear();
            textBox3_Description.Clear();
            textBox_courseid.Clear();
            comboBox_id.SelectedIndex = -1;

            if (isPlaceholderActive)
            {
                comboBox_id.Text = "Search by Course Id";
                comboBox_id.ForeColor = Color.Gray;
            }

            showdata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Check if ID is provided in DataGridView or TextBox
                if (string.IsNullOrWhiteSpace(textBox_courseid.Text))
                {
                    MessageBox.Show("Please select a course to update.", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Collect data from textboxes
                int id = Convert.ToInt32(textBox_courseid.Text);
                string cName = textBox_coursename.Text;
                int hr = Convert.ToInt32(textBox2_hour.Text);
                string desc = textBox3_Description.Text;

                // 3. Validation check (blank or empty fields)
                if (string.IsNullOrWhiteSpace(cName) || string.IsNullOrWhiteSpace(desc))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Call updateCourse function
                if (cc.updateCourse(id, cName, hr, desc))
                {
                    MessageBox.Show("Course Updated Successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView & ComboBox
                    showdata();
                    fillCourseCombo();
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox_courseid.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_courseid.Text);

                    if (cc.deleteCourse(id))
                    {
                        showdata();
                        fillCourseCombo();

                        textBox_courseid.Clear();
                        textBox_coursename.Clear();
                        textBox2_hour.Clear();
                        textBox3_Description.Clear();

                        MessageBox.Show("Course Deleted", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            clear();
        }

        private void dataGridView_newcourse_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage_course.CurrentRow != null && dataGridView_manage_course.CurrentRow.Cells[0].Value != null)
            {
                textBox_courseid.Text = dataGridView_manage_course.CurrentRow.Cells[0].Value.ToString();
                textBox_coursename.Text = dataGridView_manage_course.CurrentRow.Cells[1].Value.ToString();
                textBox2_hour.Text = dataGridView_manage_course.CurrentRow.Cells[2].Value.ToString();
                textBox3_Description.Text = dataGridView_manage_course.CurrentRow.Cells[3].Value.ToString();
            }
        }

        // Search Button Functionality
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (isPlaceholderActive || string.IsNullOrWhiteSpace(comboBox_id.Text) || !int.TryParse(comboBox_id.Text.Trim(), out int searchId))
            {
                MessageBox.Show("Please select or type a valid Course ID in the combo box!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable searchResult = cc.searchCourse(searchId.ToString());

            if (searchResult.Rows.Count > 0)
            {
                dataGridView_manage_course.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No course found with this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_manage_course.DataSource = null;
            }
        }

        // ComboBox SelectedIndexChanged Functionality (Auto filter)
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPlaceholderActive && comboBox_id.SelectedIndex != -1 && comboBox_id.SelectedValue != null)
            {
                if (int.TryParse(comboBox_id.SelectedValue.ToString(), out int courseId))
                {
                    DataTable searchResult = cc.searchCourse(courseId.ToString());

                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridView_manage_course.DataSource = searchResult;
                    }
                    else
                    {
                        dataGridView_manage_course.DataSource = null;
                    }
                }
            }
        }

        private void dataGridView_newcourse_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox_courseid_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox_search_course_TextChanged(object sender, EventArgs e) { }
    }
}