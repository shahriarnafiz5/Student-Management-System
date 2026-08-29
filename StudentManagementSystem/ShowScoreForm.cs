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
    public partial class ShowScoreForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";
        private string loggedInUsername;

        public ShowScoreForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            LoadStudentScores();
        }

        private void ShowScoreForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadStudentScores()
        {
            if (string.IsNullOrEmpty(loggedInUsername))
            {
                MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT C.CourseName, S.Score 
                                     FROM Scores S
                                     INNER JOIN Courses C ON S.CourseId = C.CourseId
                                     WHERE S.StdId = (SELECT StdId FROM student WHERE username = @Username)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", loggedInUsername);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridView_score.DataSource = dt;

                                // বাম পাশের অতিরিক্ত কলাম বা হেডার মুছে ফেলা হলো
                                dataGridView_score.RowHeadersVisible = false;

                                dataGridView_score.Dock = DockStyle.Fill;
                                dataGridView_score.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                                dataGridView_score.RowTemplate.Height = 40;
                                dataGridView_score.ColumnHeadersHeight = 45;
                                dataGridView_score.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            else
                            {
                                MessageBox.Show("No scores found for this username: " + loggedInUsername, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}