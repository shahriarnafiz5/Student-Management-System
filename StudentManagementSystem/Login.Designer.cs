namespace StudentManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox_username = new TextBox();
            label3 = new Label();
            textBox_password = new TextBox();
            label4 = new Label();
            rbtn_admin = new RadioButton();
            rbtn_student = new RadioButton();
            btn_login = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 70);
            panel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 71, 160);
            label14.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(79, 36);
            label14.Name = "label14";
            label14.Size = new Size(397, 34);
            label14.TabIndex = 4;
            label14.Text = "Mdemy International School";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(312, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(359, 261);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 6;
            label1.Text = "Login First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(312, 319);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 7;
            label2.Text = "Username :";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(312, 342);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(224, 27);
            textBox_username.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(312, 387);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 9;
            label3.Text = "Password :";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(312, 410);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(224, 27);
            textBox_password.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(312, 466);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 11;
            label4.Text = "Login as :";
            // 
            // rbtn_admin
            // 
            rbtn_admin.AutoSize = true;
            rbtn_admin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_admin.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_admin.Location = new Point(401, 466);
            rbtn_admin.Name = "rbtn_admin";
            rbtn_admin.Size = new Size(77, 24);
            rbtn_admin.TabIndex = 12;
            rbtn_admin.TabStop = true;
            rbtn_admin.Text = "Admin";
            rbtn_admin.UseVisualStyleBackColor = true;
            rbtn_admin.CheckedChanged += rbtn_admin_CheckedChanged;
            // 
            // rbtn_student
            // 
            rbtn_student.AutoSize = true;
            rbtn_student.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_student.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_student.Location = new Point(484, 466);
            rbtn_student.Name = "rbtn_student";
            rbtn_student.Size = new Size(85, 24);
            rbtn_student.TabIndex = 13;
            rbtn_student.TabStop = true;
            rbtn_student.Text = "Student";
            rbtn_student.UseVisualStyleBackColor = true;
            rbtn_student.CheckedChanged += rbtn_student_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 71, 160);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(359, 515);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(154, 49);
            btn_login.TabIndex = 14;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(851, 576);
            Controls.Add(btn_login);
            Controls.Add(rbtn_student);
            Controls.Add(rbtn_admin);
            Controls.Add(label4);
            Controls.Add(textBox_password);
            Controls.Add(label3);
            Controls.Add(textBox_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label14;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox_username;
        private Label label3;
        private TextBox textBox_password;
        private Label label4;
        private RadioButton rbtn_admin;
        private RadioButton rbtn_student;
        private Button btn_login;
    }
}