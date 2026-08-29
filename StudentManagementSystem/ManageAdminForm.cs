using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageAdminForm : Form
    {
        Admin manageAdmin = new Admin();
        int selectedAdminId = 0;
        string oldUsername = ""; // To track username changes for updating the Users table

        // Flag to prevent comboBox1_SelectedIndexChanged from filtering the grid
        // when we are programmatically reloading the ComboBox's DataSource.
        private bool isLoadingCombo = false;

        public ManageAdminForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ManageAdminForm_Load);
        }

        // Load all admin info into the DataGridView as soon as the form loads
        private void ManageAdminForm_Load(object sender, EventArgs e)
        {
            LoadAdminGrid(); // Loads data immediately when the form opens
            LoadAdminIdsToComboBox(); // Loads IDs into the combobox
        }

        // Main method to load data into the DataGridView without any interference
        private void LoadAdminGrid()
        {
            try
            {
                DataTable dtGrid = manageAdmin.GetAllAdmins();
                dataGridView_admin.DataSource = null; // reset before rebinding
                dataGridView_admin.DataSource = dtGrid;

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

        // Loads all admin IDs into the ComboBox. Uses isLoadingCombo flag so that
        // resetting the DataSource here does NOT trigger the filter logic in
        // comboBox1_SelectedIndexChanged.
        private void LoadAdminIdsToComboBox()
        {
            try
            {
                isLoadingCombo = true;

                DataTable dt = manageAdmin.GetAllAdmins();
                comboBox1.DataSource = null; // reset old binding first
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Id";
                comboBox1.ValueMember = "Id";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading IDs: " + ex.Message);
            }
            finally
            {
                isLoadingCombo = false;
            }
        }

        // Clicking any row in the DataGridView will fill the fields with data
        private void dataGridView_admin_Click(object sender, EventArgs e)
        {
            if (dataGridView_admin.CurrentRow != null && dataGridView_admin.CurrentRow.Index >= 0)
            {
                selectedAdminId = Convert.ToInt32(dataGridView_admin.CurrentRow.Cells["Id"].Value?.ToString() ?? "0");

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
                oldUsername = textBox_username.Text; // Save old username to track changes
                textBox_address.Text = dataGridView_admin.CurrentRow.Cells["Address"].Value?.ToString() ?? "";

                // পাসওয়ার্ড ফিল্ড গ্রিডক্লিক করার পর খালি রাখা ভালো যাতে আগের হাশ পাসওয়ার্ড দেখা না যায় বা ভুলবশত ওভাররাইট না হয়
                textBox_password.Clear();
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
                string rawPassword = manageAdmin.GenerateRandomPassword(8);
                string hashedPass = manageAdmin.HashPassword(rawPassword);

                string name = textBox_Fname.Text.Trim();
                string phone = textBox_phone.Text.Trim();
                DateTime dob = dateTimePicker1.Value.Date;
                string gender = rbtn_male.Checked ? "Male" : "Female";
                string username = textBox_username.Text.Trim();
                string address = textBox_address.Text.Trim();

                bool success = manageAdmin.InsertAdmin(name, phone, dob, gender, username, hashedPass, address);

                if (success)
                {
                    MessageBox.Show("Admin registered successfully!\n\nTemporary auto-generated password is: " + rawPassword +
                                    "\n(Please note this down; the hashed format is stored in the database.)",
                                    "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshGridAndCombo();
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
            RefreshGridAndCombo(); // Reset grid view back to show all admins when clearing
        }

        private void ClearFields()
        {
            textBox_Fname.Clear();
            textBox_phone.Clear();
            textBox_username.Clear();
            textBox_address.Clear();
            textBox_password.Clear();
            rbtn_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            selectedAdminId = 0;
            oldUsername = "";
        }

        private void textBox_Fname_TextChanged(object sender, EventArgs e)
        {
        }

        // Filters the grid to a single admin when a specific ID is picked from the ComboBox.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingCombo) return; // ignore during programmatic DataSource reload

            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedValue != null)
            {
                if (comboBox1.SelectedValue is DataRowView)
                {
                    return; // Ignore during form initialization
                }

                try
                {
                    string selectedId = comboBox1.SelectedValue.ToString();

                    DataTable dt = manageAdmin.GetAllAdmins();
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = $"Convert(Id, 'System.String') = '{selectedId}'";

                    if (dv.Count > 0)
                    {
                        dataGridView_admin.DataSource = dv.ToTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please select or type an ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = manageAdmin.GetAllAdmins();
                string searchId = comboBox1.Text.Trim();

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Convert(Id, 'System.String') = '{searchId}'";

                if (dv.Count > 0)
                {
                    dataGridView_admin.DataSource = dv.ToTable();
                }
                else
                {
                    MessageBox.Show("No admin found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridAndCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedAdminId == 0)
            {
                MessageBox.Show("Please select an admin from the DataGridView.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Fname.Text) ||
                string.IsNullOrWhiteSpace(textBox_username.Text) ||
                string.IsNullOrWhiteSpace(textBox_phone.Text) ||
                string.IsNullOrWhiteSpace(textBox_address.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string name = textBox_Fname.Text.Trim();
                string phone = textBox_phone.Text.Trim();
                DateTime dob = dateTimePicker1.Value.Date;
                string gender = rbtn_male.Checked ? "Male" : "Female";
                string username = textBox_username.Text.Trim();
                string address = textBox_address.Text.Trim();

                string hashedPassword;

                // নতুন পাসওয়ার্ড দেওয়া হলে সেটি হ্যাশ করবে, না হলে গ্রিডে থাকা আগের পাসওয়ার্ডটিই বহাল রাখবে
                if (!string.IsNullOrWhiteSpace(textBox_password.Text))
                {
                    string newRawPassword = textBox_password.Text.Trim();
                    hashedPassword = manageAdmin.HashPassword(newRawPassword);
                }
                else
                {
                    hashedPassword = dataGridView_admin.CurrentRow.Cells["Password"].Value?.ToString() ?? "";
                }

                // 1. Update Admin table details
                bool success = manageAdmin.UpdateAdmin(selectedAdminId, name, phone, dob, gender, username, hashedPassword, address);

                if (success)
                {
                    // 2. Sync changes to the Users table
                    try
                    {
                        manageAdmin.UpdateUser(oldUsername, username, hashedPassword);
                    }
                    catch (Exception exUser)
                    {
                        MessageBox.Show("Admin updated, but encountered an issue updating the Users table: " + exUser.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MessageBox.Show("Admin information updated successfully!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshGridAndCombo();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Button Click Event Implementation
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedAdminId == 0)
            {
                MessageBox.Show("Please select an admin from the DataGridView to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult check = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                    string usernameToDelete = textBox_username.Text.Trim();

                    // 1. Delete the specific admin from the Admins table
                    bool success = manageAdmin.DeleteAdmin(selectedAdminId);

                    if (success)
                    {
                        // 2. Also remove the admin from the Users table
                        try
                        {
                            manageAdmin.DeleteUser(usernameToDelete);
                        }
                        catch (Exception exUser)
                        {
                            MessageBox.Show("Deleted from Admin table, but encountered an issue removing from the Users table: " + exUser.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        MessageBox.Show("Admin deleted successfully!", "Successful Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshGridAndCombo();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Centralized refresh helper
        private void RefreshGridAndCombo()
        {
            LoadAdminGrid();
            LoadAdminIdsToComboBox();
        }
    }
}