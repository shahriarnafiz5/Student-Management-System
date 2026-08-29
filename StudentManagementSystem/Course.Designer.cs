namespace StudentManagementSystem
{
    partial class Course
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
            textBox3_Description = new TextBox();
            label5 = new Label();
            textBox2_hour = new TextBox();
            label2 = new Label();
            textBox_coursename = new TextBox();
            label1 = new Label();
            dataGridView_newcourse = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_newcourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(9, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 90);
            panel1.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(475, 29);
            label7.Name = "label7";
            label7.Size = new Size(180, 34);
            label7.TabIndex = 19;
            label7.Text = "New Course";
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
            btn_add.TabIndex = 36;
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
            btn_clear.TabIndex = 35;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // textBox3_Description
            // 
            textBox3_Description.Location = new Point(21, 665);
            textBox3_Description.Multiline = true;
            textBox3_Description.Name = "textBox3_Description";
            textBox3_Description.Size = new Size(612, 82);
            textBox3_Description.TabIndex = 30;
            textBox3_Description.TextChanged += textBox3_Address_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(21, 626);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 29;
            label5.Text = "Description :";
            label5.Click += label5_Click;
            // 
            // textBox2_hour
            // 
            textBox2_hour.Location = new Point(21, 582);
            textBox2_hour.Name = "textBox2_hour";
            textBox2_hour.Size = new Size(190, 27);
            textBox2_hour.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(21, 540);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 22;
            label2.Text = "Hour :";
            label2.Click += label2_Click;
            // 
            // textBox_coursename
            // 
            textBox_coursename.Location = new Point(21, 494);
            textBox_coursename.Name = "textBox_coursename";
            textBox_coursename.Size = new Size(612, 27);
            textBox_coursename.TabIndex = 21;
            textBox_coursename.TextChanged += textBox_Fname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(21, 459);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 20;
            label1.Text = "Course Name :";
            // 
            // dataGridView_newcourse
            // 
            dataGridView_newcourse.AllowUserToAddRows = false;
            dataGridView_newcourse.AllowUserToDeleteRows = false;
            dataGridView_newcourse.BackgroundColor = Color.Gainsboro;
            dataGridView_newcourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_newcourse.Location = new Point(21, 103);
            dataGridView_newcourse.Name = "dataGridView_newcourse";
            dataGridView_newcourse.RowHeadersWidth = 51;
            dataGridView_newcourse.RowTemplate.Height = 80;
            dataGridView_newcourse.Size = new Size(1059, 331);
            dataGridView_newcourse.TabIndex = 19;
            dataGridView_newcourse.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(panel1);
            Controls.Add(btn_add);
            Controls.Add(btn_clear);
            Controls.Add(textBox3_Description);
            Controls.Add(label5);
            Controls.Add(textBox2_hour);
            Controls.Add(label2);
            Controls.Add(textBox_coursename);
            Controls.Add(label1);
            Controls.Add(dataGridView_newcourse);
            Name = "Course";
            Text = "Course";
            Load += Course_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_newcourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button btn_add;
        private Button btn_clear;
        private TextBox textBox3_Description;
        private Label label5;
        private TextBox textBox2_hour;
        private Label label2;
        private TextBox textBox_coursename;
        private Label label1;
        private DataGridView dataGridView_newcourse;
    }
}