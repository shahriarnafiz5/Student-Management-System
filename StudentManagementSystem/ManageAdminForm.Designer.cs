namespace StudentManagementSystem
{
    partial class ManageAdminForm
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
            textBox_username = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            btn_update = new Button();
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
            label2 = new Label();
            textBox_password = new TextBox();
            btn_search = new Button();
            comboBox1 = new ComboBox();
            btn_delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).BeginInit();
            SuspendLayout();
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(148, 640);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(162, 27);
            textBox_username.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(22, 640);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 51;
            label1.Text = "Username :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 90);
            panel1.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(412, 28);
            label7.Name = "label7";
            label7.Size = new Size(226, 34);
            label7.TabIndex = 19;
            label7.Text = "Manage Admin";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Green;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(965, 707);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 37);
            btn_update.TabIndex = 49;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Orange;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(853, 707);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 37);
            btn_clear.TabIndex = 48;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(657, 507);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(190, 27);
            textBox_phone.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(559, 504);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 46;
            label6.Text = "Phone :";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(148, 694);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(544, 50);
            textBox_address.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(33, 694);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 44;
            label5.Text = "Address :";
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_female.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_female.Location = new Point(743, 577);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(104, 27);
            rbtn_female.TabIndex = 43;
            rbtn_female.Text = "Female";
            rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            rbtn_male.AutoSize = true;
            rbtn_male.Checked = true;
            rbtn_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_male.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_male.Location = new Point(657, 577);
            rbtn_male.Name = "rbtn_male";
            rbtn_male.Size = new Size(80, 27);
            rbtn_male.TabIndex = 42;
            rbtn_male.TabStop = true;
            rbtn_male.Text = "Male";
            rbtn_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(546, 577);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 41;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 570);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(2, 577);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 39;
            label3.Text = "Date of Birth :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(148, 504);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(162, 27);
            textBox_Fname.TabIndex = 38;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.ForeColor = Color.FromArgb(0, 71, 160);
            label_name.Location = new Point(60, 507);
            label_name.Name = "label_name";
            label_name.Size = new Size(82, 23);
            label_name.TabIndex = 37;
            label_name.Text = "Name :";
            // 
            // dataGridView_admin
            // 
            dataGridView_admin.AllowUserToAddRows = false;
            dataGridView_admin.AllowUserToDeleteRows = false;
            dataGridView_admin.BackgroundColor = Color.Gainsboro;
            dataGridView_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_admin.Location = new Point(12, 148);
            dataGridView_admin.Name = "dataGridView_admin";
            dataGridView_admin.RowHeadersWidth = 51;
            dataGridView_admin.RowTemplate.Height = 80;
            dataGridView_admin.Size = new Size(1059, 331);
            dataGridView_admin.TabIndex = 36;
            dataGridView_admin.Click += dataGridView_admin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(522, 640);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 53;
            label2.Text = "Password :";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(657, 636);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(162, 27);
            textBox_password.TabIndex = 54;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Blue;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(981, 96);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 55;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(657, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 28);
            comboBox1.TabIndex = 56;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(743, 707);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 57;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // ManageAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(btn_delete);
            Controls.Add(comboBox1);
            Controls.Add(btn_search);
            Controls.Add(textBox_password);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_update);
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
            Name = "ManageAdminForm";
            Text = "ManageAdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_username;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Button btn_update;
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
        private Label label2;
        private TextBox textBox_password;
        private Button btn_search;
        private ComboBox comboBox1;
        private Button btn_delete;
    }
}