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
    public partial class EnrollToCourse : Form
    {
        DBconnect connect = new DBconnect();
        private bool isPlaceholderActive = true; // Variable to track placeholder status

        public EnrollToCourse()
        {
            InitializeComponent();
            showData();
            dataGridView_enroll_course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_enroll_course.Dock = DockStyle.None;
            dataGridView_enroll_course.RowHeadersVisible = false;

            fillStudentCombo();
            fillCourseCombo();
            SetupComboBoxPlaceholder();
        }

        // Method to set placeholder in the combobox
        private void SetupComboBoxPlaceholder()
        {
            comboBox_id.Text = "Search by Student Id";
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
                comboBox_id.Text = "Search by Student Id";
                comboBox_id.ForeColor = Color.Gray;
            }
        }

        public void fillStudentCombo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT StdId FROM student", connect.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBox_id.DataSource = table;
                comboBox_id.DisplayMember = "StdId";
                comboBox_id.ValueMember = "StdId";
                comboBox_id.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillCourseCombo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT CourseId FROM Courses", connect.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBox_course.DataSource = table;
                comboBox_course.DisplayMember = "CourseId";
                comboBox_course.ValueMember = "CourseId";
                comboBox_course.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showData()
        {
            CourseEnrollment enrollObj = new CourseEnrollment();
            dataGridView_enroll_course.DataSource = enrollObj.getStudentCourseList();
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_studentid.Text) || string.IsNullOrWhiteSpace(comboBox_course.Text))
                {
                    MessageBox.Show("Please enter Student ID and select/type a Course ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stdId = Convert.ToInt32(textBox_studentid.Text.Trim());
                int courseId = Convert.ToInt32(comboBox_course.Text.Trim());

                SqlCommand checkStudentCmd = new SqlCommand("SELECT COUNT(*) FROM student WHERE StdId = @stdId", connect.getConnection());
                checkStudentCmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;

                connect.openConnect();
                int studentExists = (int)checkStudentCmd.ExecuteScalar();
                connect.closeConnect();

                if (studentExists == 0)
                {
                    MessageBox.Show("Invalid Student ID! This student does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand checkCourseCmd = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE CourseId = @courseId", connect.getConnection());
                checkCourseCmd.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;

                connect.openConnect();
                int courseExists = (int)checkCourseCmd.ExecuteScalar();
                connect.closeConnect();

                if (courseExists == 0)
                {
                    MessageBox.Show("Invalid Course ID! This course does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand insertCmd = new SqlCommand("INSERT INTO StudentCourses (StdId, CourseId, CourseName) SELECT @stdId, @courseId, CourseName FROM Courses WHERE CourseId = @courseId", connect.getConnection());
                insertCmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
                insertCmd.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;

                connect.openConnect();
                int rowsAffected = insertCmd.ExecuteNonQuery();
                connect.closeConnect();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_studentid.Clear();
                    comboBox_course.SelectedIndex = -1;
                    comboBox_course.Text = "";
                    showData();
                }
                else
                {
                    MessageBox.Show("Failed to enroll the course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric IDs.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search button functionality
        private void btn_search_std_Click(object sender, EventArgs e)
        {
            if (isPlaceholderActive || string.IsNullOrWhiteSpace(comboBox_id.Text) || !int.TryParse(comboBox_id.Text.Trim(), out int stdId))
            {
                MessageBox.Show("Please select or type a valid Student ID in the combo box!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CourseEnrollment enrollObj = new CourseEnrollment();
            DataTable searchResult = enrollObj.getStudentCoursesById(stdId);

            if (searchResult.Rows.Count > 0)
            {
                dataGridView_enroll_course.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No data found in database for this ID.");
                dataGridView_enroll_course.DataSource = null;
            }
        }

        // Automatically filter when an ID is selected from the combobox
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPlaceholderActive && comboBox_id.SelectedIndex != -1 && comboBox_id.SelectedValue != null)
            {
                if (int.TryParse(comboBox_id.SelectedValue.ToString(), out int stdId))
                {
                    CourseEnrollment enrollObj = new CourseEnrollment();
                    DataTable searchResult = enrollObj.getStudentCoursesById(stdId);

                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridView_enroll_course.DataSource = searchResult;
                    }
                    else
                    {
                        dataGridView_enroll_course.DataSource = null;
                    }
                }
            }
        }

        // Delete button functionality
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_studentid.Text) || string.IsNullOrWhiteSpace(comboBox_course.Text))
                {
                    MessageBox.Show("Please enter Student ID and select/type a Course ID to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stdId = Convert.ToInt32(textBox_studentid.Text.Trim());
                int courseId = Convert.ToInt32(comboBox_course.Text.Trim());

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this course enrollment for the student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM StudentCourses WHERE StdId = @stdId AND CourseId = @courseId", connect.getConnection());
                    deleteCmd.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
                    deleteCmd.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;

                    connect.openConnect();
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    connect.closeConnect();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course enrollment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_studentid.Clear();
                        comboBox_course.SelectedIndex = -1;
                        comboBox_course.Text = "";
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("No matching enrollment found with this Student ID and Course ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric IDs for Student and Course.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e) { }
        private void btn_delete_Click(object sender, EventArgs e) { button_delete_Click(sender, e); }
        private void dataGridView_enroll_course_Click(object sender, EventArgs e) { }
        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}