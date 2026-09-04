using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Login : Form
    {
        // কানেকশন স্ট্রিং
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // ডিফল্টভাবে Admin রেডিও বাটন সিলেক্টেড থাকবে
            rbtn_admin.Checked = true;
        }

        // পাসওয়ার্ড হাশ করার মেথড (SHA256)
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // মূল লগইন বাটন ক্লিক ইভেন্ট
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();

            // ফিল্ডগুলো খালি আছে কি না চেক করা
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string hashedPassword = HashPassword(password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // ১. যদি Admin রেডিও বাটন সিলেক্ট করা থাকে
                    if (rbtn_admin.Checked)
                    {
                        string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password AND (LOWER(Role) = 'admin' OR LOWER(Role) = 'superadmin')";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", hashedPassword);

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count == 1)
                            {
                                MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // সফল লগইনের পর ইউজারনেম MainForm-এ পাস করে দেওয়া হলো
                                MainForm mainForm = new MainForm(username);
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Admin Username, Password, or Role Access!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    // ২. যদি Student রেডিও বাটন সিলেক্ট করা থাকে
                    else if (rbtn_student.Checked)
                    {
                        string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password AND LOWER(Role) = 'student'";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", hashedPassword);

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count == 1)
                            {
                                MessageBox.Show("Student Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // ইউজারনেম পাস করে স্টুডেন্ট ফর্ম বা MainForm ওপেন করা
                                StudentPortal studentForm = new StudentPortal(username);
                                studentForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Student Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select 'Admin' or 'Student' to login.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtn_admin_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_student_CheckedChanged(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            btn_login_Click(sender, e);
        }
    }
}