namespace StudentManagementSystem
{
    partial class StudentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPortal));
            main_panel = new Panel();
            btn_exit = new Button();
            btn_dashboard = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_show_score = new Button();
            btn_show_information = new Button();
            panelChildForm = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            label14 = new Label();
            panel8 = new Panel();
            main_panel.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChildForm.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.FromArgb(0, 71, 160);
            main_panel.Controls.Add(btn_exit);
            main_panel.Controls.Add(btn_dashboard);
            main_panel.Controls.Add(panel7);
            main_panel.Controls.Add(btn_show_score);
            main_panel.Controls.Add(btn_show_information);
            main_panel.Location = new Point(0, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(188, 755);
            main_panel.TabIndex = 0;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(0, 71, 200);
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(0, 145);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(188, 49);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(0, 71, 200);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Location = new Point(0, 94);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(188, 49);
            btn_dashboard.TabIndex = 9;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 71, 160);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(188, 69);
            panel7.Name = "panel7";
            panel7.Size = new Size(666, 80);
            panel7.TabIndex = 8;
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
            // btn_show_score
            // 
            btn_show_score.BackColor = Color.FromArgb(0, 71, 200);
            btn_show_score.FlatStyle = FlatStyle.Flat;
            btn_show_score.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_show_score.ForeColor = Color.White;
            btn_show_score.Location = new Point(0, 46);
            btn_show_score.Name = "btn_show_score";
            btn_show_score.Size = new Size(188, 49);
            btn_show_score.TabIndex = 1;
            btn_show_score.Text = "Show Score";
            btn_show_score.UseVisualStyleBackColor = false;
            btn_show_score.Click += btn_show_score_Click;
            // 
            // btn_show_information
            // 
            btn_show_information.BackColor = Color.FromArgb(0, 71, 200);
            btn_show_information.FlatStyle = FlatStyle.Flat;
            btn_show_information.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_show_information.ForeColor = Color.White;
            btn_show_information.Location = new Point(0, 0);
            btn_show_information.Name = "btn_show_information";
            btn_show_information.Size = new Size(188, 49);
            btn_show_information.TabIndex = 0;
            btn_show_information.Text = "Show Information";
            btn_show_information.UseVisualStyleBackColor = false;
            btn_show_information.Click += btn_show_information_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChildForm.Controls.Add(panel1);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Controls.Add(panel6);
            panelChildForm.Controls.Add(panel8);
            panelChildForm.Location = new Point(188, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1125, 755);
            panelChildForm.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 80);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(979, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 71, 160);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 4;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 71, 160);
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 3);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Mdemy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 71, 160);
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 37);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Role :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 71, 160);
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(42, 3);
            label8.Name = "label8";
            label8.Size = new Size(116, 23);
            label8.TabIndex = 1;
            label8.Text = "Welcome :";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1125, 530);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label14);
            panel6.ForeColor = Color.Blue;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1306, 72);
            panel6.TabIndex = 7;
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
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 71, 160);
            panel8.Location = new Point(0, 672);
            panel8.Name = "panel8";
            panel8.Size = new Size(1125, 83);
            panel8.TabIndex = 9;
            // 
            // StudentPortal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 757);
            Controls.Add(panelChildForm);
            Controls.Add(main_panel);
            Name = "StudentPortal";
            Text = "StudentPortal";
            main_panel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChildForm.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Button btn_show_information;
        private Button btn_show_score;
        private Panel panelChildForm;
        private Panel panel7;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label label14;
        private Panel panel8;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Button btn_dashboard;
        private Button btn_exit;
    }
}