namespace StudentManagementSystem
{
    partial class AdminForm
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
            panel1 = new Panel();
            label7 = new Label();
            btn_add = new Button();
            btn_clear = new Button();
            textBox_phone = new TextBox();
            label6 = new Label();
            textBox_address = new TextBox();
            label5 = new Label();
            rbtn_female = new RadioButton();
            rbtn_male = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox_Fname = new TextBox();
            label_name = new Label();
            dataGridView_admin = new DataGridView();
            label1 = new Label();
            textBox_username = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(9, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 90);
            panel1.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(412, 28);
            label7.Name = "label7";
            label7.Size = new Size(171, 34);
            label7.TabIndex = 19;
            label7.Text = "Registration";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 71, 160);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(970, 714);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 37);
            btn_add.TabIndex = 32;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Orange;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(870, 714);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 37);
            btn_clear.TabIndex = 31;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(662, 479);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(190, 27);
            textBox_phone.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(564, 476);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 29;
            label6.Text = "Phone :";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(153, 666);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(690, 50);
            textBox_address.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(38, 666);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 27;
            label5.Text = "Address :";
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_female.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_female.Location = new Point(748, 549);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(104, 27);
            rbtn_female.TabIndex = 26;
            rbtn_female.Text = "Female";
            rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            rbtn_male.AutoSize = true;
            rbtn_male.Checked = true;
            rbtn_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_male.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_male.Location = new Point(662, 549);
            rbtn_male.Name = "rbtn_male";
            rbtn_male.Size = new Size(80, 27);
            rbtn_male.TabIndex = 25;
            rbtn_male.TabStop = true;
            rbtn_male.Text = "Male";
            rbtn_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(551, 549);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 24;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 542);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(375, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(7, 549);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 22;
            label3.Text = "Date of Birth :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(153, 476);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(162, 27);
            textBox_Fname.TabIndex = 21;
            textBox_Fname.TextChanged += textBox_Fname_TextChanged;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.ForeColor = Color.FromArgb(0, 71, 160);
            label_name.Location = new Point(65, 479);
            label_name.Name = "label_name";
            label_name.Size = new Size(82, 23);
            label_name.TabIndex = 20;
            label_name.Text = "Name :";
            // 
            // dataGridView_admin
            // 
            dataGridView_admin.AllowUserToAddRows = false;
            dataGridView_admin.AllowUserToDeleteRows = false;
            dataGridView_admin.BackgroundColor = Color.Gainsboro;
            dataGridView_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_admin.Location = new Point(21, 103);
            dataGridView_admin.Name = "dataGridView_admin";
            dataGridView_admin.RowHeadersWidth = 51;
            dataGridView_admin.RowTemplate.Height = 80;
            dataGridView_admin.Size = new Size(1059, 331);
            dataGridView_admin.TabIndex = 19;
          
            dataGridView_admin.Click += dataGridView_admin_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(27, 612);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 34;
            label1.Text = "Username :";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(153, 612);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(162, 27);
            textBox_username.TabIndex = 35;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_add);
            Controls.Add(btn_clear);
            Controls.Add(textBox_phone);
            Controls.Add(label6);
            Controls.Add(textBox_address);
            Controls.Add(label5);
            Controls.Add(rbtn_female);
            Controls.Add(rbtn_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox_Fname);
            Controls.Add(label_name);
            Controls.Add(dataGridView_admin);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button btn_add;
        private Button btn_clear;
        private TextBox textBox_phone;
        private Label label6;
        private TextBox textBox_address;
        private Label label5;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox_Fname;
        private Label label_name;
        private DataGridView dataGridView_admin;
        private Label label1;
        private TextBox textBox_username;
    }
}