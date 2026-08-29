using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        student std = new student();
        private string currentUsername;
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        public MainForm(string username = "")
        {
            InitializeComponent();
            customizeDesign();
            currentUsername = username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Main Form
            studentcount();



        }
        private void studentcount()
        {
            total_student_label.Text = "Total Student : " + std.totalStudent();
            male_label.Text = "Male : " + std.maleStudent();
            female_label.Text = "Female : " + std.femaleStudent();

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_coursesubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
            panel_admin_submenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true) panel_stdsubmenu.Visible = false;
            if (panel_coursesubmenu.Visible == true) panel_coursesubmenu.Visible = false;
            if (panel_scoresubmenu.Visible == true) panel_scoresubmenu.Visible = false;
            if (panel_admin_submenu.Visible == true) panel_admin_submenu.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false;

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            //Student button

            showSubmenu(panel_stdsubmenu);
        }

        private void btn_manage_student_Click(object sender, EventArgs e)
        {
            //Manage Button
            openChildForm(new manageStudent());
            hideSubmenu();

        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            //Registration button
            openChildForm(new RegisterForm());
            hideSubmenu();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {

            hideSubmenu();
            openChildForm(new EnrollToCourse());
        }

        private void btn_print_click(object sender, EventArgs e)
        {
            //Print student button
            hideSubmenu();
            openChildForm(new PrintStudent());
        }







        //private void button4_Click(object sender, EventArgs e)
        //{


        //}

        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {
            //First
        }



        private void btn_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }

        private void btn_new_course_Click(object sender, EventArgs e)
        {
            //New Course Button
            hideSubmenu();
            openChildForm(new Course());
        }

        private void btn_manage_course_Click(object sender, EventArgs e)
        {
            //Button Manage Course
            hideSubmenu();
            openChildForm(new CourseManageForm());
        }

        private void btn_print_course_Click(object sender, EventArgs e)
        {
            //Print Course Button
            hideSubmenu();
            openChildForm(new PrintCourseForm());
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            //Score Button
            showSubmenu(panel_scoresubmenu);
        }

        private void btn_new_score_Click(object sender, EventArgs e)
        {
            //New Score Button
            hideSubmenu();
            openChildForm(new ScoreForm());
        }

        private void btn_manage_score_Click(object sender, EventArgs e)
        {

            hideSubmenu();
            openChildForm(new UpdateScoreForm());
        }

        private void btn_print_score_Click(object sender, EventArgs e)
        {
            //Print Score button
            hideSubmenu();
            openChildForm(new PrintScoreForm());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            chief_panel.Controls.Add(childForm);
            chief_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            chief_panel.Controls.Add(cover_panel);
            studentcount();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_admin_submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            // যদি currentUsername খালি বা null থাকে, তবে সোজা আটকিয়ে দেবে
            if (string.IsNullOrEmpty(currentUsername))
            {
                hideSubmenu();
                MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentUsername.Trim().ToLower() == "nahinshahriar")
            {
                bool isSuperAdminValid = CheckSuperAdminPasswordInDatabase(currentUsername);

                if (isSuperAdminValid)
                {
                    showSubmenu(panel_admin_submenu);
                }
                else
                {
                    hideSubmenu();
                    MessageBox.Show("You are not a super admin / Invalid Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                hideSubmenu();
                MessageBox.Show("You are not a super admin", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ডেটাবেজে পাসওয়ার্ড ও ইউজারনেম চেক করার মেথড
        private bool CheckSuperAdminPasswordInDatabase(string username)
        {
            // আপনি চাইলে এখানে পাসওয়ার্ড চেক করার জন্য একটি ইনপুট ডায়ালগ বক্স দিতে পারেন 
            // অথবা ডেটাবেজ থেকে সুপারঅ্যাডমিন রোল নিশ্চিত করতে পারেন।
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string qry = "SELECT COUNT(1) FROM Users WHERE Username = @usr AND Role = 'superadmin'";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@usr", username);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
            }
        }
        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new AdminForm());
        }

        private void btn_manage_admin_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new ManageAdminForm());
        }

        private void btn_print_admin_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm(new printadmin());
        }

        private void panel_scoresubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
