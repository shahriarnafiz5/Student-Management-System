using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class manageStudent : Form
    {
        student std = new student();
        DBconnect connect = new DBconnect();
        int selectedId = 0;
        string oldUsername = ""; // পুরোনো ইউজারনেম ট্র্যাক করার জন্য
        private bool isPlaceholderActive = true; // প্লেসহোল্ডার ট্র্যাক করার জন্য

        public manageStudent()
        {
            InitializeComponent();
        }

        private void manageStudent_Load(object sender, EventArgs e)
        {
            showTable();
            fillStudentCombo();
            SetupComboBoxPlaceholder();
        }

        // To show table in the data grid view
        public void showTable()
        {
            dataGridView_manage.DataSource = std.getStudentlist();
            dataGridView_manage.RowTemplate.Height = 40;
            dataGridView_manage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_manage.RowHeadersVisible = false;
        }

        // স্টুডেন্ট আইডি কম্বোবক্সে লোড করার মেথড
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

        // কম্বোবক্সে প্লেসহোল্ডার সেট করার মেথড
        private void SetupComboBoxPlaceholder()
        {
            comboBox_id.Text = "Search by Student Id";
            comboBox_id.ForeColor = Color.Gray;

            comboBox_id.Enter += ComboBox_id_Enter;
            comboBox_id.Leave += ComboBox_id_Leave;
        }

        // কম্বোবক্সে ক্লিক বা ফোকাস করলে লেখা মুছে যাবে
        private void ComboBox_id_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                comboBox_id.Text = "";
                comboBox_id.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        // কম্বোবক্স থেকে ফোকাস চলে গেলে এবং খালি থাকলে প্লেসহোল্ডার ফিরে আসবে
        private void ComboBox_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                isPlaceholderActive = true;
                comboBox_id.Text = "Search by Student Id";
                comboBox_id.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView_manage_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView_manage_CellClick(object sender, DataGridViewCellEventArgs e) { }

        // Display specific student information including Username and Password in TextBoxes
        private void dataGridView_manage_Click(object sender, EventArgs e)
        {
            if (dataGridView_manage.CurrentRow != null && dataGridView_manage.CurrentRow.Cells[0].Value != null)
            {
                selectedId = Convert.ToInt32(dataGridView_manage.CurrentRow.Cells[0].Value.ToString());
                textBox_id.Text = selectedId.ToString();
                textBox_Fname.Text = dataGridView_manage.CurrentRow.Cells[1].Value.ToString();
                textBox2_Lname.Text = dataGridView_manage.CurrentRow.Cells[2].Value.ToString();

                if (dataGridView_manage.CurrentRow.Cells[3].Value != DBNull.Value)
                {
                    dateTimePicker1.Value = (DateTime)dataGridView_manage.CurrentRow.Cells[3].Value;
                }

                if (dataGridView_manage.CurrentRow.Cells[4].Value.ToString() == "Male")
                {
                    rbtn_male.Checked = true;
                }
                else
                {
                    rbtn_female.Checked = true;
                }

                textBox4_Phone.Text = dataGridView_manage.CurrentRow.Cells[5].Value.ToString();
                textBox3_Address.Text = dataGridView_manage.CurrentRow.Cells[6].Value.ToString();

                // ইউজারনেম লোড করা হচ্ছে
                textBox_username.Text = dataGridView_manage.CurrentRow.Cells[7].Value.ToString();
                oldUsername = textBox_username.Text.Trim(); // পুরোনো ইউজারনেম সেভ রাখা হলো

                // সিকিউরিটির জন্য গ্রিড থেকে পাসওয়ার্ড টেক্সটবক্সে না এনে খালি রাখা ভালো, 
                // তবে আগের হ্যাশ পাসওয়ার্ডটি আপডেট মেথডের জন্য গ্রিডেই ব্যাকআপ হিসেবে থাকবে।
                textBox_password.Clear();
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox2_Lname.Clear();
            textBox3_Address.Clear();
            textBox4_Phone.Clear();
            textBox_username.Clear();
            textBox_password.Clear();
            oldUsername = ""; // ক্লিয়ার করার সময় রিসেট করা হলো
            dateTimePicker1.Value = DateTime.Now;
            rbtn_male.Checked = true;
            textBox_id.Clear();
            comboBox_id.SelectedIndex = -1;

            if (isPlaceholderActive)
            {
                comboBox_id.Text = "Search by Student Id";
                comboBox_id.ForeColor = Color.Gray;
            }

            showTable();
        }

        // Search Button Functionality
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaceholderActive || string.IsNullOrWhiteSpace(comboBox_id.Text) || !int.TryParse(comboBox_id.Text.Trim(), out int searchId))
            {
                MessageBox.Show("Please select or type a valid Student ID in the combo box!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable searchResult = std.searchStudent(searchId.ToString());

            if (searchResult.Rows.Count > 0)
            {
                dataGridView_manage.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No student found with this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_manage.DataSource = null;
            }
        }

        // ComboBox SelectedIndexChanged Functionality (অটোমেটিক ফিল্টার হবে)
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPlaceholderActive && comboBox_id.SelectedIndex != -1 && comboBox_id.SelectedValue != null)
            {
                if (int.TryParse(comboBox_id.SelectedValue.ToString(), out int stdId))
                {
                    DataTable searchResult = std.searchStudent(stdId.ToString());

                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridView_manage.DataSource = searchResult;
                    }
                    else
                    {
                        dataGridView_manage.DataSource = null;
                    }
                }
            }
        }

        // Field verification
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

        // Update Button Click Event (পাসওয়ার্ড হ্যাশ করাসহ আপডেট লজিক)
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a student from the DataGridView to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!verify())
            {
                MessageBox.Show("Please fill in all required fields (Password can be left blank if you don't want to change it).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = selectedId;
                string fname = textBox_Fname.Text.Trim();
                string lname = textBox2_Lname.Text.Trim();
                DateTime bdate = dateTimePicker1.Value;
                string gender = rbtn_male.Checked ? "Male" : "Female";
                string phone = textBox4_Phone.Text.Trim();
                string address = textBox3_Address.Text.Trim();
                string newUsername = textBox_username.Text.Trim();

                string hashedPassword = "";

                // যদি নতুন পাসওয়ার্ড টাইপ করা হয়, তবে সেটি হ্যাশ করবে। না হলে গ্রিড থেকে আগের পাসওয়ার্ডটি নিয়ে নেবে।
                if (!string.IsNullOrWhiteSpace(textBox_password.Text))
                {
                    string newRawPassword = textBox_password.Text.Trim();
                    hashedPassword = std.HashPassword(newRawPassword); // ছাত্রের ক্লাসে হ্যাশ মেথড থাকলে তা কল হবে
                }
                else
                {
                    if (dataGridView_manage.CurrentRow != null && dataGridView_manage.CurrentRow.Cells[8].Value != null)
                    {
                        hashedPassword = dataGridView_manage.CurrentRow.Cells[8].Value.ToString();
                    }
                }

                // ১. স্টুডেন্ট টেবিল আপডেট করা
                if (std.updateStudent(id, fname, lname, bdate, gender, phone, address, newUsername, hashedPassword))
                {
                    // ২. Users টেবিল আপডেট বা সিঙ্ক করা
                    try
                    {
                        using (SqlCommand cmdUserUpdate = new SqlCommand("UPDATE Users SET Username = @newUsr, Password = @pwd WHERE Username = @oldUsr", connect.getConnection()))
                        {
                            cmdUserUpdate.Parameters.Add("@newUsr", SqlDbType.VarChar).Value = newUsername;
                            cmdUserUpdate.Parameters.Add("@pwd", SqlDbType.VarChar).Value = hashedPassword;
                            cmdUserUpdate.Parameters.Add("@oldUsr", SqlDbType.VarChar).Value = oldUsername;

                            connect.openConnect();
                            cmdUserUpdate.ExecuteNonQuery();
                            connect.closeConnect();
                        }
                    }
                    catch (Exception exUser)
                    {
                        MessageBox.Show("Student updated, but failed to sync Users table: " + exUser.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    showTable();
                    fillStudentCombo();
                    MessageBox.Show("Student Data Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clr_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error: Student Data Could Not Be Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_id.Text))
                {
                    MessageBox.Show("Please select a student to delete", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(textBox_id.Text);
                string usernameToDelete = textBox_username.Text.Trim();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DBconnect db = new DBconnect();

                    // ১. Scores টেবিল থেকে চাইল্ড রেকর্ড ডিলিট করা
                    using (SqlCommand cmdScores = new SqlCommand("DELETE FROM Scores WHERE StdId = @id", db.getConnection()))
                    {
                        cmdScores.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        db.openConnect();
                        cmdScores.ExecuteNonQuery();
                        db.closeConnect();
                    }

                    // ২. StudentCourses টেবিল থেকে চাইল্ড রেকর্ড ডিলিট করা
                    using (SqlCommand cmdCourses = new SqlCommand("DELETE FROM StudentCourses WHERE StdId = @id", db.getConnection()))
                    {
                        cmdCourses.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        db.openConnect();
                        cmdCourses.ExecuteNonQuery();
                        db.closeConnect();
                    }

                    // ৩. Users টেবিল থেকে ওই স্টুডেন্টের লগইন তথ্য ডিলিট করা
                    if (!string.IsNullOrEmpty(usernameToDelete))
                    {
                        using (SqlCommand cmdUsers = new SqlCommand("DELETE FROM Users WHERE Username = @username", db.getConnection()))
                        {
                            cmdUsers.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameToDelete;
                            db.openConnect();
                            cmdUsers.ExecuteNonQuery();
                            db.closeConnect();
                        }
                    }

                    // ৪. মূল student টেবিল থেকে স্টুডেন্ট ডিলিট করা
                    if (std.deleteStudent(id))
                    {
                        showTable();
                        fillStudentCombo();
                        MessageBox.Show("Student and Login Account Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_clr_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error: Student Could Not Be Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e) { }
        private void textBox_id_TextChanged_1(object sender, EventArgs e) { }
    }
}