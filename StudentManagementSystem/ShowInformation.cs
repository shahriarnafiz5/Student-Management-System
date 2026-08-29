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
    public partial class ShowInformation : Form
    {
        // Database connection string for your project
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";
        private string loggedInUsername;

        // Receiving the logged-in username through the constructor
        public ShowInformation(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void ShowInformation_Load(object sender, EventArgs e)
        {
            // The method to fetch data will be called as soon as the form loads
            LoadStudentInformation();
        }

        private void LoadStudentInformation()
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

                    // Table and column names have been adjusted according to your schema
                    string query = "SELECT * FROM student WHERE username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", loggedInUsername);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assigning data to textboxes based on table column names
                                id.Text = reader["StdId"].ToString();
                                fname.Text = reader["StdFirstName"].ToString();
                                lname.Text = reader["StdLastName"].ToString();
                                dob.Text = reader["Birthdate"].ToString();
                                gender.Text = reader["Gender"].ToString();
                                phone.Text = reader["Phone"].ToString();
                                address.Text = reader["Address"].ToString();
                                username.Text = reader["username"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No student information found for this username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}