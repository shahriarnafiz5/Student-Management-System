using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // Ensure this for SQL classes

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        student std = new student();
        DBconnect connect = new DBconnect(); // Object added for database connection

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        // To show table in the data grid view
        public void showTable()
        {
            dataGridView1.DataSource = std.getStudentlist();
            dataGridView1.RowTemplate.Height = 40;
        }

        // Field verification (Checking fields including the Username textbox)
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_Fname.Text) ||
                string.IsNullOrWhiteSpace(textBox2_Lname.Text) ||
                string.IsNullOrWhiteSpace(textBox3_Address.Text) ||
                string.IsNullOrWhiteSpace(textBox4_Phone.Text) ||
                string.IsNullOrWhiteSpace(textBox_username.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Function to auto-generate password
        private string GeneratePassword()
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ0123456789@#$";
            char[] chars = new char[8];
            Random rd = new Random();
            for (int i = 0; i < 8; i++)
            {
                chars[i] = allowedChars[rd.Next(allowedChars.Length)];
            }
            return new string(chars);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = textBox_Fname.Text.Trim();
                string lname = textBox2_Lname.Text.Trim();
                DateTime date = dateTimePicker1.Value;
                string phone = textBox4_Phone.Text.Trim();
                string address = textBox3_Address.Text.Trim();
                string gender = rbtn_male.Checked ? "Male" : "Female";

                // Getting the username from the username textbox
                string username = textBox_username.Text.Trim();

                // Student age check (10 to 20 years)
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                int age = this_year - born_year;

                if (age < 10 || age > 20)
                {
                    MessageBox.Show("The student age must be between 10 and 20", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!verify())
                {
                    MessageBox.Show("Please fill all empty fields (including Username)", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Auto-generating the password
                string autoPassword = GeneratePassword();

                // 1. First, data is inserted into the student table
                if (std.insertStudent(fname, lname, date, gender, phone, address, username, autoPassword))
                {
                    // 2. Then, the new student's login information is directly inserted into the 'Users' table
                    SqlCommand userCommand = new SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@uUser, @uPass, @uRole)", connect.getConnection());
                    userCommand.Parameters.Add("@uUser", SqlDbType.VarChar).Value = username;
                    userCommand.Parameters.Add("@uPass", SqlDbType.VarChar).Value = autoPassword;
                    userCommand.Parameters.Add("@uRole", SqlDbType.VarChar).Value = "Student";

                    connect.openConnect();
                    userCommand.ExecuteNonQuery();
                    connect.closeConnect();

                    showTable();
                    MessageBox.Show("New Student Added Successfully & Saved to Users Table!\n\nUsername: " + username + "\nGenerated Password: " + autoPassword,
                                    "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clear_Click(sender, e); // Clear fields after successful insert
                }
                else
                {
                    MessageBox.Show("Error: Student Could Not Be Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                connect.closeConnect(); // To safely close the connection if any error occurs
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox2_Lname.Clear();
            textBox3_Address.Clear();
            textBox4_Phone.Clear();
            textBox_username.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rbtn_male.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_Fname_TextChanged(object sender, EventArgs e) { }
        private void textBox2_Lname_TextChanged(object sender, EventArgs e) { }
        private void textBox4_Phone_TextChanged(object sender, EventArgs e) { }
        private void textBox3_Address_TextChanged(object sender, EventArgs e) { }
        private void rbtn_male_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_female_CheckedChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}