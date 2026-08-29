
namespace StudentManagementSystem
{
    partial class UpdateScoreForm
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
            textBox_score = new TextBox();
            label_score = new Label();
            textBox_course_name = new TextBox();
            label_course_name = new Label();
            comboBox_id = new ComboBox();
            btn_search = new Button();
            panel1 = new Panel();
            label7 = new Label();
            textBox_courseid = new TextBox();
            label2 = new Label();
            textBox_student_id = new TextBox();
            dataGridView_manage = new DataGridView();
            btn_student_id = new Label();
            btn_update_score = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).BeginInit();
            SuspendLayout();
            // 
            // textBox_score
            // 
            textBox_score.Location = new Point(107, 552);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(162, 27);
            textBox_score.TabIndex = 66;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score.ForeColor = Color.FromArgb(0, 71, 160);
            label_score.Location = new Point(24, 552);
            label_score.Name = "label_score";
            label_score.Size = new Size(77, 23);
            label_score.TabIndex = 65;
            label_score.Text = "Score :";
            // 
            // textBox_course_name
            // 
            textBox_course_name.Location = new Point(883, 480);
            textBox_course_name.Name = "textBox_course_name";
            textBox_course_name.Size = new Size(190, 27);
            textBox_course_name.TabIndex = 64;
            // 
            // label_course_name
            // 
            label_course_name.AutoSize = true;
            label_course_name.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_course_name.ForeColor = Color.FromArgb(0, 71, 160);
            label_course_name.Location = new Point(707, 484);
            label_course_name.Name = "label_course_name";
            label_course_name.Size = new Size(157, 23);
            label_course_name.TabIndex = 63;
            label_course_name.Text = "Course Name :";
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(648, 80);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(300, 28);
            comboBox_id.TabIndex = 62;
            comboBox_id.Enter += comboBox_id_Enter;
            comboBox_id.Leave += comboBox_id_Leave;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Orange;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(954, 76);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(107, 37);
            btn_search.TabIndex = 61;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 68);
            panel1.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(463, 17);
            label7.Name = "label7";
            label7.Size = new Size(162, 34);
            label7.TabIndex = 19;
            label7.Text = "New Score";
            // 
            // textBox_courseid
            // 
            textBox_courseid.Location = new Point(496, 484);
            textBox_courseid.Name = "textBox_courseid";
            textBox_courseid.Size = new Size(190, 27);
            textBox_courseid.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(354, 484);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 58;
            label2.Text = "Course Id :";
            // 
            // textBox_student_id
            // 
            textBox_student_id.Location = new Point(107, 484);
            textBox_student_id.Name = "textBox_student_id";
            textBox_student_id.Size = new Size(162, 27);
            textBox_student_id.TabIndex = 57;
            // 
            // dataGridView_manage
            // 
            dataGridView_manage.AllowUserToAddRows = false;
            dataGridView_manage.AllowUserToDeleteRows = false;
            dataGridView_manage.BackgroundColor = Color.Gainsboro;
            dataGridView_manage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_manage.Location = new Point(14, 114);
            dataGridView_manage.Name = "dataGridView_manage";
            dataGridView_manage.RowHeadersWidth = 51;
            dataGridView_manage.RowTemplate.Height = 80;
            dataGridView_manage.Size = new Size(1059, 347);
            dataGridView_manage.TabIndex = 56;
            dataGridView_manage.Click += dataGridView_manage_Click;
            // 
            // btn_student_id
            // 
            btn_student_id.AutoSize = true;
            btn_student_id.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_student_id.ForeColor = Color.FromArgb(0, 71, 160);
            btn_student_id.Location = new Point(60, 484);
            btn_student_id.Name = "btn_student_id";
            btn_student_id.Size = new Size(41, 23);
            btn_student_id.TabIndex = 67;
            btn_student_id.Text = "Id :";
            // 
            // btn_update_score
            // 
            btn_update_score.BackColor = Color.OrangeRed;
            btn_update_score.FlatStyle = FlatStyle.Flat;
            btn_update_score.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_score.ForeColor = Color.White;
            btn_update_score.Location = new Point(430, 627);
            btn_update_score.Name = "btn_update_score";
            btn_update_score.Size = new Size(166, 59);
            btn_update_score.TabIndex = 68;
            btn_update_score.Text = "Update Score";
            btn_update_score.UseVisualStyleBackColor = false;
            btn_update_score.Click += btn_update_score_Click;
            // 
            // UpdateScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(btn_update_score);
            Controls.Add(btn_student_id);
            Controls.Add(textBox_score);
            Controls.Add(label_score);
            Controls.Add(textBox_course_name);
            Controls.Add(label_course_name);
            Controls.Add(comboBox_id);
            Controls.Add(btn_search);
            Controls.Add(panel1);
            Controls.Add(textBox_courseid);
            Controls.Add(label2);
            Controls.Add(textBox_student_id);
            Controls.Add(dataGridView_manage);
            Name = "UpdateScoreForm";
            Text = "UpdateScoreForm";
            Load += UpdateScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_score;
        private Label label_score;
        private TextBox textBox_course_name;
        private Label label_course_name;
        private ComboBox comboBox_id;
        private Button btn_search;
        private Panel panel1;
        private Label label7;
        private TextBox textBox_courseid;
        private Label label2;
        private TextBox textBox_student_id;
        private DataGridView dataGridView_manage;
        private Label btn_student_id;
        private Button btn_update_score;
    }
}