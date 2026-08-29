using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class UpdateScoreForm : Form
    {
        Score scoreClass = new Score();

        public UpdateScoreForm()
        {
            InitializeComponent();
        }

        // 1. Form load event
        private void UpdateScoreForm_Load(object sender, EventArgs e)
        {
            LoadStudentIdsToComboBox();
            dataGridView_manage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Method to load IDs into the ComboBox
        private void LoadStudentIdsToComboBox()
        {
            try
            {
                scoreClass.LoadStudentIdsToComboBox(comboBox_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_id_Enter(object sender, EventArgs e)
        {
            if (comboBox_id.Text == "Search or Select Student id")
            {
                comboBox_id.Text = "";
            }
        }

        private void comboBox_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                comboBox_id.Text = "Search or Select Student id";
            }
        }

        // 2. Load courses when an ID is selected or changed from the ComboBox
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedIndex == -1 || comboBox_id.SelectedValue == null)
                return;

            int selectedStdId;
            if (!int.TryParse(comboBox_id.SelectedValue.ToString(), out selectedStdId))
                return;

            LoadStudentCourses(selectedStdId);
        }

        // 3. Method to load courses and scores for a specific student
        private void LoadStudentCourses(int stdId)
        {
            try
            {
                textBox_student_id.Text = stdId.ToString();
                DataTable dt = scoreClass.GetStudentCourses(stdId);
                dataGridView_manage.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 4. Search button click event
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchIdText = "";

            if (comboBox_id.SelectedValue != null && !string.IsNullOrEmpty(comboBox_id.SelectedValue.ToString()) && comboBox_id.SelectedValue.ToString() != "Search or Select Student id")
            {
                searchIdText = comboBox_id.SelectedValue.ToString();
            }
            else if (!string.IsNullOrEmpty(comboBox_id.Text) && comboBox_id.Text != "Search or Select Student id")
            {
                searchIdText = comboBox_id.Text;
            }
            else if (!string.IsNullOrEmpty(textBox_student_id.Text))
            {
                searchIdText = textBox_student_id.Text;
            }
            else
            {
                MessageBox.Show("Please select an ID from the combobox or enter an ID in the textbox!");
                return;
            }

            int searchStdId;
            if (!int.TryParse(searchIdText, out searchStdId))
            {
                MessageBox.Show("Please provide a valid student ID!");
                return;
            }

            LoadStudentCourses(searchStdId);
        }

        // 5. Populate textboxes with data when clicking on a row in the DataGridView
        private void dataGridView_manage_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage.CurrentRow != null)
            {
                if (dataGridView_manage.CurrentRow.Cells["StdId"].Value != null)
                {
                    textBox_student_id.Text = dataGridView_manage.CurrentRow.Cells["StdId"].Value.ToString();
                }

                textBox_courseid.Text = dataGridView_manage.CurrentRow.Cells["CourseId"].Value.ToString();
                textBox_course_name.Text = dataGridView_manage.CurrentRow.Cells["CourseName"].Value.ToString();

                string scoreVal = dataGridView_manage.CurrentRow.Cells["Score"].Value.ToString();
                textBox_score.Text = (scoreVal == "---") ? string.Empty : scoreVal;
            }
        }

        // 6. Update button click event
        private void btn_update_score_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_student_id.Text) || string.IsNullOrEmpty(textBox_courseid.Text) || string.IsNullOrEmpty(textBox_score.Text))
            {
                MessageBox.Show("Please enter the student ID, course, and new score!");
                return;
            }

            int stdId = Convert.ToInt32(textBox_student_id.Text);
            int courseId = Convert.ToInt32(textBox_courseid.Text);
            decimal score = Convert.ToDecimal(textBox_score.Text);

            try
            {
                bool success = scoreClass.UpdateScore(stdId, courseId, score);
                if (success)
                {
                    MessageBox.Show("Score updated successfully!");
                    LoadStudentCourses(stdId);

                    textBox_courseid.Clear();
                    textBox_course_name.Clear();
                    textBox_score.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}