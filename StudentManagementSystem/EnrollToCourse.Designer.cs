namespace StudentManagementSystem
{
    partial class EnrollToCourse
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
            btn_search = new Button();
            btn_delete = new Button();
            btn_search_std = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_enroll_course = new DataGridView();
            label1 = new Label();
            textBox_studentid = new TextBox();
            btn_add_course = new Button();
            comboBox_id = new ComboBox();
            comboBox_course = new ComboBox();
            button_delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_enroll_course).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Orange;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(1100, 103);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 64;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(1096, 715);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 52;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_search_std
            // 
            btn_search_std.BackColor = Color.Orange;
            btn_search_std.FlatStyle = FlatStyle.Flat;
            btn_search_std.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_std.ForeColor = Color.White;
            btn_search_std.Location = new Point(971, 88);
            btn_search_std.Name = "btn_search_std";
            btn_search_std.Size = new Size(104, 37);
            btn_search_std.TabIndex = 69;
            btn_search_std.Text = "Search";
            btn_search_std.UseVisualStyleBackColor = false;
            btn_search_std.Click += btn_search_std_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(6, 582);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 67;
            label3.Text = "Course Id :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 85);
            panel1.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(456, 25);
            label7.Name = "label7";
            label7.Size = new Size(192, 34);
            label7.TabIndex = 19;
            label7.Text = "Enroll Course";
            // 
            // dataGridView_enroll_course
            // 
            dataGridView_enroll_course.AllowUserToAddRows = false;
            dataGridView_enroll_course.AllowUserToDeleteRows = false;
            dataGridView_enroll_course.BackgroundColor = Color.Gainsboro;
            dataGridView_enroll_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_enroll_course.Location = new Point(6, 137);
            dataGridView_enroll_course.Name = "dataGridView_enroll_course";
            dataGridView_enroll_course.RowHeadersWidth = 51;
            dataGridView_enroll_course.RowTemplate.Height = 80;
            dataGridView_enroll_course.Size = new Size(1069, 425);
            dataGridView_enroll_course.TabIndex = 65;
            dataGridView_enroll_course.Click += dataGridView_enroll_course_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(3, 625);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 71;
            label1.Text = "Student Id :";
            // 
            // textBox_studentid
            // 
            textBox_studentid.Location = new Point(128, 625);
            textBox_studentid.Name = "textBox_studentid";
            textBox_studentid.Size = new Size(172, 27);
            textBox_studentid.TabIndex = 72;
            // 
            // btn_add_course
            // 
            btn_add_course.BackColor = Color.FromArgb(0, 71, 180);
            btn_add_course.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_course.ForeColor = Color.White;
            btn_add_course.Location = new Point(283, 675);
            btn_add_course.Name = "btn_add_course";
            btn_add_course.Size = new Size(189, 54);
            btn_add_course.TabIndex = 73;
            btn_add_course.Text = "Add Course";
            btn_add_course.UseVisualStyleBackColor = false;
            btn_add_course.Click += btn_add_course_Click;
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(707, 95);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(240, 28);
            comboBox_id.TabIndex = 74;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // comboBox_course
            // 
            comboBox_course.FormattingEnabled = true;
            comboBox_course.Location = new Point(128, 582);
            comboBox_course.Name = "comboBox_course";
            comboBox_course.Size = new Size(172, 28);
            comboBox_course.TabIndex = 75;
            comboBox_course.SelectedIndexChanged += comboBox_course_SelectedIndexChanged;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Red;
            button_delete.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(544, 675);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(189, 54);
            button_delete.TabIndex = 76;
            button_delete.Text = "Delete Course";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // EnrollToCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(button_delete);
            Controls.Add(comboBox_course);
            Controls.Add(comboBox_id);
            Controls.Add(btn_add_course);
            Controls.Add(textBox_studentid);
            Controls.Add(label1);
            Controls.Add(btn_search_std);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dataGridView_enroll_course);
            Controls.Add(btn_search);
            Controls.Add(btn_delete);
            Name = "EnrollToCourse";
            Text = "EnrollToCourse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_enroll_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_search;
        private Button btn_delete;
        private Button btn_search_std;
        private Label label3;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_enroll_course;
        private Label label1;
        private TextBox textBox_studentid;
        private Button btn_add_course;
        private ComboBox comboBox_id;
        private ComboBox comboBox_course;
        private Button button_delete;
    }
}