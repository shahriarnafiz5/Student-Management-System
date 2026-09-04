using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AdminForm : Form
    {
        Admin adminClass = new Admin();
        DBconnect connect = new DBconnect(); // Database connection object added

        public AdminForm()
        {
            InitializeComponent();
        }

        // Load all admin information into the DataGridView as soon as the form loads
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAdminGrid();
        }

        // Main method to load data into the DataGridView
        private void LoadAdminGrid()
        {
            try
            {
                dataGridView_admin.DataSource = adminClass.GetAllAdmins();
                dataGridView_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_admin.RowHeadersVisible = false;

                // Ensure full row select mode programmatically
                dataGridView_admin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_admin.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Clicking any row in the DataGridView will fill the textboxes and fields with data
        private void dataGridView_admin_Click(object sender, EventArgs e)
        {
            if (dataGridView_admin.CurrentRow != null && dataGridView_admin.CurrentRow.Index >= 0)
            {
                textBox_Fname.Text = dataGridView_admin.CurrentRow.Cells["Name"].Value?.ToString() ?? "";
                textBox_phone.Text = dataGridView_admin.CurrentRow.Cells["Phone"].Value?.ToString() ?? "";

                if (dataGridView_admin.CurrentRow.Cells["BirthDate"].Value != DBNull.Value && dataGridView_admin.CurrentRow.Cells["BirthDate"].Value != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView_admin.CurrentRow.Cells["BirthDate"].Value);
                }

                string gender = dataGridView_admin.CurrentRow.Cells["Gender"].Value?.ToString() ?? "";
                if (gender == "Female")
                {
                    rbtn_female.Checked = true;
                }
                else
                {
                    rbtn_male.Checked = true;
                }

                textBox_username.Text = dataGridView_admin.CurrentRow.Cells["Username"].Value?.ToString() ?? "";
                textBox_address.Text = dataGridView_admin.CurrentRow.Cells["Address"].Value?.ToString() ?? "";
            }
        }

        // Add Button Click Event
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Fname.Text) ||
                string.IsNullOrWhiteSpace(textBox_username.Text) ||
                string.IsNullOrWhiteSpace(textBox_phone.Text) || string.IsNullOrWhiteSpace(textBox_address.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                string rawPassword = adminClass.GenerateRandomPassword(8);
                string hashedPass = adminClass.HashPassword(rawPassword);

                string name = textBox_Fname.Text.Trim();
                string phone = textBox_phone.Text.Trim();
                DateTime dob = dateTimePicker1.Value.Date;
                string gender = rbtn_male.Checked ? "Male" : "Female";
                string username = textBox_username.Text.Trim();
                string address = textBox_address.Text.Trim();

                // 1. Save the new admin into the main Admin table
                bool success = adminClass.InsertAdmin(name, phone, dob, gender, username, hashedPass, address);

                if (success)
                {
                    // 2. Insert the new admin's credentials into the Users table (so they can log in)
                    try
                    {
                        using (SqlCommand cmdUsers = new SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)", connect.getConnection()))
                        {
                            cmdUsers.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                            cmdUsers.Parameters.Add("@password", SqlDbType.VarChar).Value = hashedPass; // Or rawPassword depending on login authentication setup
                            cmdUsers.Parameters.Add("@role", SqlDbType.VarChar).Value = "Admin"; // Set role as Admin

                            connect.openConnect();
                            cmdUsers.ExecuteNonQuery();
                            connect.closeConnect();
                        }
                    }
                    catch (Exception exUser)
                    {
                        MessageBox.Show("Saved to Admin table, but encountered an issue adding to the Users table: " + exUser.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MessageBox.Show("Admin registered successfully!\n\nTemporary auto-generated password is: " + rawPassword +
                                    "\n(Please note this down; the hashed format is stored in the database.)",
                                    "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAdminGrid();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Clear Button Click Event
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox_Fname.Clear();
            textBox_phone.Clear();
            textBox_username.Clear();
            textBox_address.Clear();
            rbtn_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox_Fname_TextChanged(object sender, EventArgs e)
        {
        }
    }
}