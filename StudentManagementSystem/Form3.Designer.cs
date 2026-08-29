namespace StudentManagementSystem
{
    partial class RegisterForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox_Fname = new TextBox();
            label2 = new Label();
            textBox2_Lname = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            rbtn_male = new RadioButton();
            rbtn_female = new RadioButton();
            label5 = new Label();
            textBox3_Address = new TextBox();
            label6 = new Label();
            textBox4_Phone = new TextBox();
            btn_clear = new Button();
            btn_add = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label9 = new Label();
            textBox_username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.Size = new Size(1059, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(12, 472);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 1;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(144, 469);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(162, 32);
            textBox_Fname.TabIndex = 2;
            textBox_Fname.TextChanged += textBox1_Fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(312, 472);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 3;
            label2.Text = "Last Name :";
            label2.Click += label2_Click;
            // 
            // textBox2_Lname
            // 
            textBox2_Lname.Location = new Point(434, 472);
            textBox2_Lname.Name = "textBox2_Lname";
            textBox2_Lname.Size = new Size(190, 32);
            textBox2_Lname.TabIndex = 4;
            textBox2_Lname.TextChanged += textBox2_Lname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(-2, 542);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 5;
            label3.Text = "Date of Birth :";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 535);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(375, 32);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(542, 542);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 7;
            label4.Text = "Gender :";
            // 
            // rbtn_male
            // 
            rbtn_male.AutoSize = true;
            rbtn_male.Checked = true;
            rbtn_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_male.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_male.Location = new Point(644, 542);
            rbtn_male.Name = "rbtn_male";
            rbtn_male.Size = new Size(80, 27);
            rbtn_male.TabIndex = 8;
            rbtn_male.TabStop = true;
            rbtn_male.Text = "Male";
            rbtn_male.UseVisualStyleBackColor = true;
            rbtn_male.CheckedChanged += rbtn_male_CheckedChanged;
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtn_female.ForeColor = Color.FromArgb(0, 71, 160);
            rbtn_female.Location = new Point(730, 542);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(104, 27);
            rbtn_female.TabIndex = 9;
            rbtn_female.Text = "Female";
            rbtn_female.UseVisualStyleBackColor = true;
            rbtn_female.CheckedChanged += rbtn_female_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(36, 697);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Address :";
            // 
            // textBox3_Address
            // 
            textBox3_Address.Location = new Point(144, 694);
            textBox3_Address.Multiline = true;
            textBox3_Address.Name = "textBox3_Address";
            textBox3_Address.Size = new Size(690, 50);
            textBox3_Address.TabIndex = 11;
            textBox3_Address.TextChanged += textBox3_Address_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(630, 475);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 14;
            label6.Text = "Phone :";
            // 
            // textBox4_Phone
            // 
            textBox4_Phone.Location = new Point(710, 472);
            textBox4_Phone.Name = "textBox4_Phone";
            textBox4_Phone.Size = new Size(190, 32);
            textBox4_Phone.TabIndex = 15;
            textBox4_Phone.TextChanged += textBox4_Phone_TextChanged;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Orange;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(861, 707);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 37);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 71, 160);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(961, 707);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 37);
            btn_add.TabIndex = 17;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 90);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 71, 160);
            label9.Location = new Point(12, 613);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 20;
            label9.Text = "Username :";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(144, 610);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(162, 32);
            textBox_username.TabIndex = 22;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 759);
            Controls.Add(textBox_username);
            Controls.Add(label9);
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
            Controls.Add(dataGridView1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimumSize = new Size(1105, 806);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox_Fname;
        private Label label2;
        private TextBox textBox2_Lname;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private RadioButton rbtn_male;
        private RadioButton rbtn_female;
        private Label label5;
        private TextBox textBox3_Address;
        private Label label6;
        private TextBox textBox4_Phone;
        private Button btn_clear;
        private Button btn_add;
        private Panel panel1;
        private Label label7;
        private Label label9;
        private TextBox textBox_username;
    }
}