namespace StudentManagementSystem
{
    partial class CourseManageForm
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
            textBox3_Description = new TextBox();
            label5 = new Label();
            textBox2_hour = new TextBox();
            label2 = new Label();
            textBox_coursename = new TextBox();
            label1 = new Label();
            dataGridView_manage_course = new DataGridView();
            label3 = new Label();
            textBox_courseid = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            button1 = new Button();
            btn_search = new Button();
            comboBox_id = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage_course).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 85);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(475, 29);
            label7.Name = "label7";
            label7.Size = new Size(233, 34);
            label7.TabIndex = 19;
            label7.Text = "Manage Course";
            // 
            // textBox3_Description
            // 
            textBox3_Description.Location = new Point(20, 667);
            textBox3_Description.Multiline = true;
            textBox3_Description.Name = "textBox3_Description";
            textBox3_Description.Size = new Size(612, 82);
            textBox3_Description.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(20, 628);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 43;
            label5.Text = "Description :";
            // 
            // textBox2_hour
            // 
            textBox2_hour.Location = new Point(20, 588);
            textBox2_hour.Name = "textBox2_hour";
            textBox2_hour.Size = new Size(190, 27);
            textBox2_hour.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(20, 562);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 41;
            label2.Text = "Hour :";
            // 
            // textBox_coursename
            // 
            textBox_coursename.Location = new Point(20, 523);
            textBox_coursename.Name = "textBox_coursename";
            textBox_coursename.Size = new Size(606, 27);
            textBox_coursename.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(20, 483);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 39;
            label1.Text = "Course Name :";
            label1.Click += label1_Click;
            // 
            // dataGridView_manage_course
            // 
            dataGridView_manage_course.AllowUserToAddRows = false;
            dataGridView_manage_course.AllowUserToDeleteRows = false;
            dataGridView_manage_course.BackgroundColor = Color.Gainsboro;
            dataGridView_manage_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_manage_course.Location = new Point(20, 149);
            dataGridView_manage_course.Name = "dataGridView_manage_course";
            dataGridView_manage_course.RowHeadersWidth = 51;
            dataGridView_manage_course.RowTemplate.Height = 80;
            dataGridView_manage_course.Size = new Size(1059, 331);
            dataGridView_manage_course.TabIndex = 38;
            dataGridView_manage_course.CellContentClick += dataGridView_newcourse_CellContentClick;
            dataGridView_manage_course.Click += dataGridView_newcourse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(464, 562);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 46;
            label3.Text = "Course Id :";
            // 
            // textBox_courseid
            // 
            textBox_courseid.Location = new Point(464, 598);
            textBox_courseid.Name = "textBox_courseid";
            textBox_courseid.Size = new Size(162, 27);
            textBox_courseid.TabIndex = 47;
            textBox_courseid.TextChanged += textBox_courseid_TextChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(981, 712);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 37);
            btn_delete.TabIndex = 38;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.OrangeRed;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(870, 712);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 37);
            btn_update.TabIndex = 37;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(759, 712);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 48;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Orange;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(985, 100);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(107, 37);
            btn_search.TabIndex = 49;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(734, 109);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(230, 28);
            comboBox_id.TabIndex = 50;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // CourseManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 759);
            Controls.Add(comboBox_id);
            Controls.Add(btn_search);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(textBox_courseid);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox3_Description);
            Controls.Add(label5);
            Controls.Add(textBox2_hour);
            Controls.Add(label2);
            Controls.Add(textBox_coursename);
            Controls.Add(label1);
            Controls.Add(dataGridView_manage_course);
            Name = "CourseManageForm";
            Text = "CourseManageForm";
            Load += CourseManageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox textBox3_Description;
        private Label label5;
        private TextBox textBox2_hour;
        private Label label2;
        private TextBox textBox_coursename;
        private Label label1;
        private DataGridView dataGridView_manage_course;
        private Label label3;
        private TextBox textBox_courseid;
        private Button btn_delete;
        private Button btn_update;
        private Button button1;
        private Button btn_search;
        private ComboBox comboBox_id;
    }
}