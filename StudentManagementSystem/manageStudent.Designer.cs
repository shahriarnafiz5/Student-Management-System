namespace StudentManagementSystem
{
    partial class manageStudent
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
            textBox4_Phone = new TextBox();
            label6 = new Label();
            textBox3_Address = new TextBox();
            label5 = new Label();
            rbtn_female = new RadioButton();
            rbtn_male = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2_Lname = new TextBox();
            label2 = new Label();
            textBox_Fname = new TextBox();
            label1 = new Label();
            dataGridView_manage = new DataGridView();
            btn_clr = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            button1 = new Button();
            label8 = new Label();
            textBox_id = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            comboBox_id = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 68);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(410, 17);
            label7.Name = "label7";
            label7.Size = new Size(238, 34);
            label7.TabIndex = 19;
            label7.Text = "Manage Student";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 71, 160);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(1239, 771);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 37);
            btn_add.TabIndex = 36;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Orange;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(1139, 771);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 37);
            btn_clear.TabIndex = 35;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // textBox4_Phone
            // 
            textBox4_Phone.Location = new Point(750, 483);
            textBox4_Phone.Name = "textBox4_Phone";
            textBox4_Phone.Size = new Size(190, 32);
            textBox4_Phone.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(640, 486);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 33;
            label6.Text = "Phone :";
            // 
            // textBox3_Address
            // 
            textBox3_Address.Location = new Point(154, 697);
            textBox3_Address.Multiline = true;
            textBox3_Address.Name = "textBox3_Address";
            textBox3_Address.Size = new Size(452, 50);
            textBox3_Address.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(42, 697);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 29;
            label5.Text = "Address :";
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_female.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_female.Location = new Point(836, 553);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(104, 27);
            rbtn_female.TabIndex = 28;
            rbtn_female.Text = "Female";
            rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            rbtn_male.AutoSize = true;
            rbtn_male.Checked = true;
            rbtn_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_male.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_male.Location = new Point(750, 553);
            rbtn_male.Name = "rbtn_male";
            rbtn_male.Size = new Size(80, 27);
            rbtn_male.TabIndex = 27;
            rbtn_male.TabStop = true;
            rbtn_male.Text = "Male";
            rbtn_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(627, 553);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 26;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 546);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(375, 32);
            dateTimePicker1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(8, 553);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 24;
            label3.Text = "Date of Birth :";
            // 
            // textBox2_Lname
            // 
            textBox2_Lname.Location = new Point(444, 483);
            textBox2_Lname.Name = "textBox2_Lname";
            textBox2_Lname.Size = new Size(190, 32);
            textBox2_Lname.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(322, 483);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 22;
            label2.Text = "Last Name :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(152, 483);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(162, 32);
            textBox_Fname.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(22, 483);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 20;
            label1.Text = "First Name :";
            // 
            // dataGridView_manage
            // 
            dataGridView_manage.AllowUserToAddRows = false;
            dataGridView_manage.AllowUserToDeleteRows = false;
            dataGridView_manage.BackgroundColor = Color.Gainsboro;
            dataGridView_manage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_manage.Location = new Point(12, 113);
            dataGridView_manage.Name = "dataGridView_manage";
            dataGridView_manage.RowHeadersWidth = 51;
            dataGridView_manage.RowTemplate.Height = 80;
            dataGridView_manage.Size = new Size(1059, 347);
            dataGridView_manage.TabIndex = 19;
            dataGridView_manage.CellClick += dataGridView_manage_CellClick;
            dataGridView_manage.CellContentClick += dataGridView_manage_CellContentClick;
            dataGridView_manage.Click += dataGridView_manage_Click;
            // 
            // btn_clr
            // 
            btn_clr.BackColor = Color.Orange;
            btn_clr.FlatStyle = FlatStyle.Flat;
            btn_clr.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clr.ForeColor = Color.White;
            btn_clr.Location = new Point(730, 697);
            btn_clr.Name = "btn_clr";
            btn_clr.Size = new Size(94, 37);
            btn_clr.TabIndex = 38;
            btn_clr.Text = "Clear";
            btn_clr.UseVisualStyleBackColor = false;
            btn_clr.Click += btn_clr_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.OrangeRed;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(846, 697);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 37);
            btn_update.TabIndex = 39;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(959, 697);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 40;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(977, 70);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 42;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 71, 160);
            label8.Location = new Point(682, 622);
            label8.Name = "label8";
            label8.Size = new Size(41, 23);
            label8.TabIndex = 43;
            label8.Text = "Id :";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(750, 619);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(162, 32);
            textBox_id.TabIndex = 44;
            textBox_id.TextChanged += textBox_id_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 71, 160);
            label9.Location = new Point(350, 622);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 45;
            label9.Text = "Password :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 71, 160);
            label10.Location = new Point(22, 622);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 46;
            label10.Text = "Username :";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(472, 619);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(162, 32);
            textBox_password.TabIndex = 47;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(152, 619);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(162, 32);
            textBox_username.TabIndex = 48;
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(699, 75);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(253, 31);
            comboBox_id.TabIndex = 49;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // manageStudent
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 759);
            Controls.Add(comboBox_id);
            Controls.Add(textBox_username);
            Controls.Add(textBox_password);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox_id);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_clr);
            Controls.Add(panel1);
            Controls.Add(btn_add);
            Controls.Add(btn_clear);
            Controls.Add(textBox4_Phone);
            Controls.Add(label6);
            Controls.Add(textBox3_Address);
            Controls.Add(label5);
            Controls.Add(rbtn_female);
            Controls.Add(rbtn_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2_Lname);
            Controls.Add(label2);
            Controls.Add(textBox_Fname);
            Controls.Add(label1);
            Controls.Add(dataGridView_manage);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1101, 806);
            Name = "manageStudent";
            Text = "manageStudent";
            Load += manageStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button btn_add;
        private Button btn_clear;
        private TextBox textBox4_Phone;
        private Label label6;
        private TextBox textBox3_Address;
        private Label label5;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2_Lname;
        private Label label2;
        private TextBox textBox_Fname;
        private Label label1;
        private DataGridView dataGridView_manage;
        private Button btn_clr;
        private Button btn_update;
        private Button btn_delete;
        private Button button1;
        private Label label8;
        private TextBox textBox_id;
        private Label label9;
        private Label label10;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private ComboBox comboBox_id;
    }
}