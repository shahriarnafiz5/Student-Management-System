namespace StudentManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Main_panel = new FlowLayoutPanel();
            btn_student = new Button();
            panel_stdsubmenu = new FlowLayoutPanel();
            btn_registration = new Button();
            btn_manage_student = new Button();
            btn_enrollcourse = new Button();
            btn_print = new Button();
            btn_course = new Button();
            panel_coursesubmenu = new FlowLayoutPanel();
            btn_new_course = new Button();
            btn_manage_course = new Button();
            btn_print_course = new Button();
            btn_score = new Button();
            panel_scoresubmenu = new FlowLayoutPanel();
            btn_new_score = new Button();
            btn_manage_score = new Button();
            btn_print_score = new Button();
            btn_dashboard = new Button();
            btn_admin = new Button();
            panel_admin_submenu = new Panel();
            btn_print_admin = new Button();
            btn_manage_admin = new Button();
            btn_add_admin = new Button();
            btn_exit = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            label14 = new Label();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            male_label = new Label();
            female_label = new Label();
            total_student_label = new Label();
            chief_panel = new Panel();
            cover_panel = new Panel();
            Main_panel.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            panel_coursesubmenu.SuspendLayout();
            panel_scoresubmenu.SuspendLayout();
            panel_admin_submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            chief_panel.SuspendLayout();
            cover_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Main_panel
            // 
            Main_panel.AutoScroll = true;
            Main_panel.BackColor = Color.FromArgb(0, 71, 160);
            Main_panel.Controls.Add(btn_student);
            Main_panel.Controls.Add(panel_stdsubmenu);
            Main_panel.Controls.Add(btn_course);
            Main_panel.Controls.Add(panel_coursesubmenu);
            Main_panel.Controls.Add(btn_score);
            Main_panel.Controls.Add(panel_scoresubmenu);
            Main_panel.Controls.Add(btn_dashboard);
            Main_panel.Controls.Add(btn_admin);
            Main_panel.Controls.Add(panel_admin_submenu);
            Main_panel.Controls.Add(btn_exit);
            Main_panel.Dock = DockStyle.Left;
            Main_panel.FlowDirection = FlowDirection.TopDown;
            Main_panel.Location = new Point(0, 0);
            Main_panel.Margin = new Padding(4, 3, 4, 3);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(230, 757);
            Main_panel.TabIndex = 0;
            Main_panel.WrapContents = false;
            Main_panel.Paint += panel1_Paint;
            // 
            // btn_student
            // 
            btn_student.FlatAppearance.BorderSize = 0;
            btn_student.FlatStyle = FlatStyle.Flat;
            btn_student.ForeColor = Color.White;
            btn_student.Location = new Point(4, 3);
            btn_student.Margin = new Padding(4, 3, 4, 3);
            btn_student.Name = "btn_student";
            btn_student.Padding = new Padding(10, 0, 0, 0);
            btn_student.Size = new Size(220, 55);
            btn_student.TabIndex = 0;
            btn_student.Text = "Student";
            btn_student.TextAlign = ContentAlignment.MiddleLeft;
            btn_student.UseVisualStyleBackColor = true;
            btn_student.Click += btn_student_Click;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.AutoSize = true;
            panel_stdsubmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_stdsubmenu.Controls.Add(btn_registration);
            panel_stdsubmenu.Controls.Add(btn_manage_student);
            panel_stdsubmenu.Controls.Add(btn_enrollcourse);
            panel_stdsubmenu.Controls.Add(btn_print);
            panel_stdsubmenu.FlowDirection = FlowDirection.TopDown;
            panel_stdsubmenu.Location = new Point(3, 64);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(220, 220);
            panel_stdsubmenu.TabIndex = 1;
            panel_stdsubmenu.WrapContents = false;
            // 
            // btn_registration
            // 
            btn_registration.FlatAppearance.BorderSize = 0;
            btn_registration.FlatStyle = FlatStyle.Flat;
            btn_registration.ForeColor = Color.White;
            btn_registration.Location = new Point(0, 0);
            btn_registration.Margin = new Padding(0);
            btn_registration.Name = "btn_registration";
            btn_registration.Padding = new Padding(35, 0, 0, 0);
            btn_registration.Size = new Size(220, 55);
            btn_registration.TabIndex = 1;
            btn_registration.Text = "Registration";
            btn_registration.TextAlign = ContentAlignment.MiddleLeft;
            btn_registration.UseVisualStyleBackColor = true;
            btn_registration.Click += btn_registration_Click;
            // 
            // btn_manage_student
            // 
            btn_manage_student.FlatAppearance.BorderSize = 0;
            btn_manage_student.FlatStyle = FlatStyle.Flat;
            btn_manage_student.ForeColor = Color.White;
            btn_manage_student.Location = new Point(0, 55);
            btn_manage_student.Margin = new Padding(0);
            btn_manage_student.Name = "btn_manage_student";
            btn_manage_student.Padding = new Padding(35, 0, 0, 0);
            btn_manage_student.Size = new Size(220, 55);
            btn_manage_student.TabIndex = 2;
            btn_manage_student.Text = "Manage Student";
            btn_manage_student.TextAlign = ContentAlignment.MiddleLeft;
            btn_manage_student.UseVisualStyleBackColor = true;
            btn_manage_student.Click += btn_manage_student_Click;
            // 
            // btn_enrollcourse
            // 
            btn_enrollcourse.FlatAppearance.BorderSize = 0;
            btn_enrollcourse.FlatStyle = FlatStyle.Flat;
            btn_enrollcourse.ForeColor = Color.White;
            btn_enrollcourse.Location = new Point(0, 110);
            btn_enrollcourse.Margin = new Padding(0);
            btn_enrollcourse.Name = "btn_enrollcourse";
            btn_enrollcourse.Padding = new Padding(35, 0, 0, 0);
            btn_enrollcourse.Size = new Size(220, 55);
            btn_enrollcourse.TabIndex = 3;
            btn_enrollcourse.Text = "Enroll Course";
            btn_enrollcourse.TextAlign = ContentAlignment.MiddleLeft;
            btn_enrollcourse.UseVisualStyleBackColor = true;
            btn_enrollcourse.Click += btn_status_Click;
            // 
            // btn_print
            // 
            btn_print.FlatAppearance.BorderSize = 0;
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.ForeColor = Color.White;
            btn_print.Location = new Point(0, 165);
            btn_print.Margin = new Padding(0);
            btn_print.Name = "btn_print";
            btn_print.Padding = new Padding(35, 0, 0, 0);
            btn_print.Size = new Size(220, 55);
            btn_print.TabIndex = 4;
            btn_print.Text = "Print";
            btn_print.TextAlign = ContentAlignment.MiddleLeft;
            btn_print.UseVisualStyleBackColor = true;
            btn_print.Click += btn_print_click;
            // 
            // btn_course
            // 
            btn_course.FlatAppearance.BorderSize = 0;
            btn_course.FlatStyle = FlatStyle.Flat;
            btn_course.ForeColor = Color.White;
            btn_course.Location = new Point(4, 290);
            btn_course.Margin = new Padding(4, 3, 4, 3);
            btn_course.Name = "btn_course";
            btn_course.Padding = new Padding(10, 0, 0, 0);
            btn_course.Size = new Size(220, 55);
            btn_course.TabIndex = 2;
            btn_course.Text = "Course";
            btn_course.TextAlign = ContentAlignment.MiddleLeft;
            btn_course.UseVisualStyleBackColor = true;
            btn_course.Click += btn_course_Click;
            // 
            // panel_coursesubmenu
            // 
            panel_coursesubmenu.AutoSize = true;
            panel_coursesubmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_coursesubmenu.Controls.Add(btn_new_course);
            panel_coursesubmenu.Controls.Add(btn_manage_course);
            panel_coursesubmenu.Controls.Add(btn_print_course);
            panel_coursesubmenu.FlowDirection = FlowDirection.TopDown;
            panel_coursesubmenu.Location = new Point(3, 351);
            panel_coursesubmenu.Name = "panel_coursesubmenu";
            panel_coursesubmenu.Size = new Size(220, 165);
            panel_coursesubmenu.TabIndex = 3;
            panel_coursesubmenu.WrapContents = false;
            // 
            // btn_new_course
            // 
            btn_new_course.FlatAppearance.BorderSize = 0;
            btn_new_course.FlatStyle = FlatStyle.Flat;
            btn_new_course.ForeColor = Color.White;
            btn_new_course.Location = new Point(0, 0);
            btn_new_course.Margin = new Padding(0);
            btn_new_course.Name = "btn_new_course";
            btn_new_course.Padding = new Padding(35, 0, 0, 0);
            btn_new_course.Size = new Size(220, 55);
            btn_new_course.TabIndex = 2;
            btn_new_course.Text = "New Course";
            btn_new_course.TextAlign = ContentAlignment.MiddleLeft;
            btn_new_course.UseVisualStyleBackColor = true;
            btn_new_course.Click += btn_new_course_Click;
            // 
            // btn_manage_course
            // 
            btn_manage_course.FlatAppearance.BorderSize = 0;
            btn_manage_course.FlatStyle = FlatStyle.Flat;
            btn_manage_course.ForeColor = Color.White;
            btn_manage_course.Location = new Point(0, 55);
            btn_manage_course.Margin = new Padding(0);
            btn_manage_course.Name = "btn_manage_course";
            btn_manage_course.Padding = new Padding(35, 0, 0, 0);
            btn_manage_course.Size = new Size(220, 55);
            btn_manage_course.TabIndex = 3;
            btn_manage_course.Text = "Manage Course";
            btn_manage_course.TextAlign = ContentAlignment.MiddleLeft;
            btn_manage_course.UseVisualStyleBackColor = true;
            btn_manage_course.Click += btn_manage_course_Click;
            // 
            // btn_print_course
            // 
            btn_print_course.FlatAppearance.BorderSize = 0;
            btn_print_course.FlatStyle = FlatStyle.Flat;
            btn_print_course.ForeColor = Color.White;
            btn_print_course.Location = new Point(0, 110);
            btn_print_course.Margin = new Padding(0);
            btn_print_course.Name = "btn_print_course";
            btn_print_course.Padding = new Padding(35, 0, 0, 0);
            btn_print_course.Size = new Size(220, 55);
            btn_print_course.TabIndex = 4;
            btn_print_course.Text = "Print";
            btn_print_course.TextAlign = ContentAlignment.MiddleLeft;
            btn_print_course.UseVisualStyleBackColor = true;
            btn_print_course.Click += btn_print_course_Click;
            // 
            // btn_score
            // 
            btn_score.FlatAppearance.BorderSize = 0;
            btn_score.FlatStyle = FlatStyle.Flat;
            btn_score.ForeColor = Color.White;
            btn_score.Location = new Point(4, 522);
            btn_score.Margin = new Padding(4, 3, 4, 3);
            btn_score.Name = "btn_score";
            btn_score.Padding = new Padding(10, 0, 0, 0);
            btn_score.Size = new Size(220, 55);
            btn_score.TabIndex = 4;
            btn_score.Text = "Score";
            btn_score.TextAlign = ContentAlignment.MiddleLeft;
            btn_score.UseVisualStyleBackColor = true;
            btn_score.Click += btn_score_Click;
            // 
            // panel_scoresubmenu
            // 
            panel_scoresubmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_scoresubmenu.Controls.Add(btn_new_score);
            panel_scoresubmenu.Controls.Add(btn_manage_score);
            panel_scoresubmenu.Controls.Add(btn_print_score);
            panel_scoresubmenu.FlowDirection = FlowDirection.TopDown;
            panel_scoresubmenu.Location = new Point(3, 583);
            panel_scoresubmenu.Name = "panel_scoresubmenu";
            panel_scoresubmenu.Size = new Size(220, 180);
            panel_scoresubmenu.TabIndex = 5;
            panel_scoresubmenu.WrapContents = false;
            panel_scoresubmenu.Paint += panel_scoresubmenu_Paint;
            // 
            // btn_new_score
            // 
            btn_new_score.FlatAppearance.BorderSize = 0;
            btn_new_score.FlatStyle = FlatStyle.Flat;
            btn_new_score.ForeColor = Color.White;
            btn_new_score.Location = new Point(0, 0);
            btn_new_score.Margin = new Padding(0);
            btn_new_score.Name = "btn_new_score";
            btn_new_score.Padding = new Padding(35, 0, 0, 0);
            btn_new_score.Size = new Size(220, 55);
            btn_new_score.TabIndex = 3;
            btn_new_score.Text = "New Score";
            btn_new_score.TextAlign = ContentAlignment.MiddleLeft;
            btn_new_score.UseVisualStyleBackColor = true;
            btn_new_score.Click += btn_new_score_Click;
            // 
            // btn_manage_score
            // 
            btn_manage_score.FlatAppearance.BorderSize = 0;
            btn_manage_score.FlatStyle = FlatStyle.Flat;
            btn_manage_score.ForeColor = Color.White;
            btn_manage_score.Location = new Point(0, 55);
            btn_manage_score.Margin = new Padding(0);
            btn_manage_score.Name = "btn_manage_score";
            btn_manage_score.Padding = new Padding(35, 0, 0, 0);
            btn_manage_score.Size = new Size(220, 55);
            btn_manage_score.TabIndex = 4;
            btn_manage_score.Text = "Manage Score";
            btn_manage_score.TextAlign = ContentAlignment.MiddleLeft;
            btn_manage_score.UseVisualStyleBackColor = true;
            btn_manage_score.Click += btn_manage_score_Click;
            // 
            // btn_print_score
            // 
            btn_print_score.FlatAppearance.BorderSize = 0;
            btn_print_score.FlatStyle = FlatStyle.Flat;
            btn_print_score.ForeColor = Color.White;
            btn_print_score.Location = new Point(0, 110);
            btn_print_score.Margin = new Padding(0);
            btn_print_score.Name = "btn_print_score";
            btn_print_score.Padding = new Padding(35, 0, 0, 0);
            btn_print_score.Size = new Size(220, 55);
            btn_print_score.TabIndex = 5;
            btn_print_score.Text = "Print";
            btn_print_score.TextAlign = ContentAlignment.MiddleLeft;
            btn_print_score.UseVisualStyleBackColor = true;
            btn_print_score.Click += btn_print_score_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Location = new Point(4, 769);
            btn_dashboard.Margin = new Padding(4, 3, 4, 3);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(220, 55);
            btn_dashboard.TabIndex = 7;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // btn_admin
            // 
            btn_admin.BackColor = Color.FromArgb(0, 71, 160);
            btn_admin.Dock = DockStyle.Top;
            btn_admin.FlatAppearance.BorderSize = 0;
            btn_admin.FlatStyle = FlatStyle.Flat;
            btn_admin.ForeColor = Color.White;
            btn_admin.Location = new Point(3, 830);
            btn_admin.Name = "btn_admin";
            btn_admin.Padding = new Padding(10, 0, 0, 0);
            btn_admin.Size = new Size(222, 55);
            btn_admin.TabIndex = 8;
            btn_admin.Text = "Admin";
            btn_admin.TextAlign = ContentAlignment.MiddleLeft;
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Click += btn_admin_Click;
            // 
            // panel_admin_submenu
            // 
            panel_admin_submenu.Controls.Add(btn_print_admin);
            panel_admin_submenu.Controls.Add(btn_manage_admin);
            panel_admin_submenu.Controls.Add(btn_add_admin);
            panel_admin_submenu.Dock = DockStyle.Top;
            panel_admin_submenu.Location = new Point(3, 891);
            panel_admin_submenu.Name = "panel_admin_submenu";
            panel_admin_submenu.Size = new Size(222, 172);
            panel_admin_submenu.TabIndex = 9;
            panel_admin_submenu.Paint += panel_admin_submenu_Paint;
            // 
            // btn_print_admin
            // 
            btn_print_admin.BackColor = Color.FromArgb(0, 71, 200);
            btn_print_admin.Dock = DockStyle.Top;
            btn_print_admin.FlatAppearance.BorderSize = 0;
            btn_print_admin.FlatStyle = FlatStyle.Flat;
            btn_print_admin.ForeColor = Color.White;
            btn_print_admin.Location = new Point(0, 110);
            btn_print_admin.Name = "btn_print_admin";
            btn_print_admin.Padding = new Padding(35, 0, 0, 0);
            btn_print_admin.Size = new Size(222, 55);
            btn_print_admin.TabIndex = 11;
            btn_print_admin.Text = "Print";
            btn_print_admin.TextAlign = ContentAlignment.MiddleLeft;
            btn_print_admin.UseVisualStyleBackColor = false;
            btn_print_admin.Click += btn_print_admin_Click;
            // 
            // btn_manage_admin
            // 
            btn_manage_admin.BackColor = Color.FromArgb(0, 71, 200);
            btn_manage_admin.Dock = DockStyle.Top;
            btn_manage_admin.FlatAppearance.BorderSize = 0;
            btn_manage_admin.FlatStyle = FlatStyle.Flat;
            btn_manage_admin.ForeColor = Color.White;
            btn_manage_admin.Location = new Point(0, 55);
            btn_manage_admin.Name = "btn_manage_admin";
            btn_manage_admin.Padding = new Padding(35, 0, 0, 0);
            btn_manage_admin.Size = new Size(222, 55);
            btn_manage_admin.TabIndex = 10;
            btn_manage_admin.Text = "Manage Admin";
            btn_manage_admin.TextAlign = ContentAlignment.MiddleLeft;
            btn_manage_admin.UseVisualStyleBackColor = false;
            btn_manage_admin.Click += btn_manage_admin_Click;
            // 
            // btn_add_admin
            // 
            btn_add_admin.BackColor = Color.FromArgb(0, 71, 200);
            btn_add_admin.Dock = DockStyle.Top;
            btn_add_admin.FlatAppearance.BorderSize = 0;
            btn_add_admin.FlatStyle = FlatStyle.Flat;
            btn_add_admin.ForeColor = Color.White;
            btn_add_admin.Location = new Point(0, 0);
            btn_add_admin.Name = "btn_add_admin";
            btn_add_admin.Padding = new Padding(35, 0, 0, 0);
            btn_add_admin.Size = new Size(222, 55);
            btn_add_admin.TabIndex = 9;
            btn_add_admin.Text = "Add Admin";
            btn_add_admin.TextAlign = ContentAlignment.MiddleLeft;
            btn_add_admin.UseVisualStyleBackColor = false;
            btn_add_admin.Click += btn_add_admin_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(0, 71, 160);
            btn_exit.Dock = DockStyle.Top;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(3, 1069);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(10, 0, 0, 0);
            btn_exit.Size = new Size(222, 55);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.TextAlign = ContentAlignment.MiddleLeft;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1082, 534);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label14);
            panel6.ForeColor = Color.Blue;
            panel6.Location = new Point(1, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1306, 72);
            panel6.TabIndex = 1;
            panel6.Paint += panel6_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(0, 71, 200);
            label14.Location = new Point(25, 24);
            label14.Name = "label14";
            label14.Size = new Size(285, 23);
            label14.TabIndex = 3;
            label14.Text = "Mdemy International School";
            label14.Click += label14_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 71, 160);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(0, 74);
            panel7.Name = "panel7";
            panel7.Size = new Size(1294, 80);
            panel7.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(979, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 71, 160);
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(173, 35);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 4;
            label7.Text = "Admin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 71, 160);
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(173, 3);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 3;
            label6.Text = "Mdemy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 71, 160);
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(93, 37);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 2;
            label5.Text = "Role :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 71, 160);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 3);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 1;
            label4.Text = "Welcome :";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 71, 160);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(male_label);
            panel8.Controls.Add(female_label);
            panel8.Controls.Add(total_student_label);
            panel8.Location = new Point(1, 674);
            panel8.Name = "panel8";
            panel8.Size = new Size(1087, 83);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 71, 160);
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(719, 50);
            label12.Name = "label12";
            label12.Size = new Size(77, 23);
            label12.TabIndex = 7;
            label12.Text = " Male :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 71, 160);
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(841, 51);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 6;
            label13.Text = "Female :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 71, 160);
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(499, 12);
            label11.Name = "label11";
            label11.Size = new Size(140, 23);
            label11.TabIndex = 5;
            label11.Text = "Select Class :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(719, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 31);
            comboBox1.TabIndex = 4;
            // 
            // male_label
            // 
            male_label.AutoSize = true;
            male_label.BackColor = Color.FromArgb(0, 71, 160);
            male_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            male_label.ForeColor = Color.White;
            male_label.Location = new Point(26, 40);
            male_label.Name = "male_label";
            male_label.Size = new Size(77, 23);
            male_label.TabIndex = 4;
            male_label.Text = " Male :";
            male_label.Click += label10_Click;
            // 
            // female_label
            // 
            female_label.AutoSize = true;
            female_label.BackColor = Color.FromArgb(0, 71, 160);
            female_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            female_label.ForeColor = Color.White;
            female_label.Location = new Point(121, 40);
            female_label.Name = "female_label";
            female_label.Size = new Size(95, 23);
            female_label.TabIndex = 3;
            female_label.Text = "Female :";
            female_label.Click += label9_Click;
            // 
            // total_student_label
            // 
            total_student_label.AutoSize = true;
            total_student_label.BackColor = Color.FromArgb(0, 71, 160);
            total_student_label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_student_label.ForeColor = Color.White;
            total_student_label.Location = new Point(26, 12);
            total_student_label.Name = "total_student_label";
            total_student_label.Size = new Size(154, 23);
            total_student_label.TabIndex = 2;
            total_student_label.Text = "Total Students :";
            // 
            // chief_panel
            // 
            chief_panel.Controls.Add(cover_panel);
            chief_panel.Dock = DockStyle.Fill;
            chief_panel.Location = new Point(230, 0);
            chief_panel.Name = "chief_panel";
            chief_panel.Size = new Size(1083, 757);
            chief_panel.TabIndex = 8;
            // 
            // cover_panel
            // 
            cover_panel.Controls.Add(panel7);
            cover_panel.Controls.Add(pictureBox2);
            cover_panel.Controls.Add(panel6);
            cover_panel.Controls.Add(panel8);
            cover_panel.Dock = DockStyle.Fill;
            cover_panel.Location = new Point(0, 0);
            cover_panel.Name = "cover_panel";
            cover_panel.Size = new Size(1083, 757);
            cover_panel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 757);
            Controls.Add(chief_panel);
            Controls.Add(Main_panel);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Main_panel.ResumeLayout(false);
            Main_panel.PerformLayout();
            panel_stdsubmenu.ResumeLayout(false);
            panel_coursesubmenu.ResumeLayout(false);
            panel_scoresubmenu.ResumeLayout(false);
            panel_admin_submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            chief_panel.ResumeLayout(false);
            cover_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Main_panel;
        private Button btn_student;
        private FlowLayoutPanel panel_stdsubmenu;
        private Button btn_print;
        private Button btn_course;
        private FlowLayoutPanel panel_coursesubmenu;
        private Button btn_print_course;
        private Button btn_manage_course;
        private Button btn_new_course;
        private Button btn_score;
        private FlowLayoutPanel panel_scoresubmenu;
        private Button btn_new_score;
        private Button btn_manage_score;
        private Button btn_print_score;
        private Button btn_registration;
        private Button btn_manage_student;
        private Panel panel6;
        private Panel panel7;
        private Label label5;
        private Label label4;
        private Panel panel8;
        private Label label7;
        private Label label6;
        private Label male_label;
        private Label female_label;
        private Label total_student_label;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label13;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label14;
        private Panel chief_panel;
        private Panel cover_panel;
        private Button btn_enrollcourse;
        private Button btn_dashboard;
        private Button btn_admin;
        private Panel panel_admin_submenu;
        private Button btn_print_admin;
        private Button btn_manage_admin;
        private Button btn_add_admin;
        private Button btn_exit;
    }
}