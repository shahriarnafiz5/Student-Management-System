namespace StudentManagementSystem
{
    partial class ScoreForm
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
            textBox_courseid = new TextBox();
            label2 = new Label();
            textBox_student_id = new TextBox();
            btn_student_id = new Label();
            dataGridView_manage = new DataGridView();
            btn_search = new Button();
            comboBox_id = new ComboBox();
            label_course_name = new Label();
            textBox_course_name = new TextBox();
            label_score = new Label();
            textBox_score = new TextBox();
            btn_add_score = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 68);
            panel1.TabIndex = 47;
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
            textBox_courseid.Location = new Point(387, 483);
            textBox_courseid.Name = "textBox_courseid";
            textBox_courseid.Size = new Size(190, 27);
            textBox_courseid.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(256, 483);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 45;
            label2.Text = "Course Id :";
            // 
            // textBox_student_id
            // 
            textBox_student_id.Location = new Point(73, 483);
            textBox_student_id.Name = "textBox_student_id";
            textBox_student_id.Size = new Size(162, 27);
            textBox_student_id.TabIndex = 44;
            textBox_student_id.TextChanged += textBox_Fname_TextChanged;
            // 
            // btn_student_id
            // 
            btn_student_id.AutoSize = true;
            btn_student_id.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_student_id.ForeColor = Color.FromArgb(0, 71, 160);
            btn_student_id.Location = new Point(26, 483);
            btn_student_id.Name = "btn_student_id";
            btn_student_id.Size = new Size(41, 23);
            btn_student_id.TabIndex = 43;
            btn_student_id.Text = "Id :";
            // 
            // dataGridView_manage
            // 
            dataGridView_manage.AllowUserToAddRows = false;
            dataGridView_manage.AllowUserToDeleteRows = false;
            dataGridView_manage.BackgroundColor = Color.Gainsboro;
            dataGridView_manage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_manage.Location = new Point(16, 113);
            dataGridView_manage.Name = "dataGridView_manage";
            dataGridView_manage.RowHeadersWidth = 51;
            dataGridView_manage.RowTemplate.Height = 80;
            dataGridView_manage.Size = new Size(1059, 347);
            dataGridView_manage.TabIndex = 42;
            dataGridView_manage.CellContentClick += dataGridView_manage_CellContentClick;
            dataGridView_manage.Click += dataGridView_manage_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Orange;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(956, 75);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(107, 37);
            btn_search.TabIndex = 50;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(650, 79);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(300, 28);
            comboBox_id.TabIndex = 51;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // label_course_name
            // 
            label_course_name.AutoSize = true;
            label_course_name.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_course_name.ForeColor = Color.FromArgb(0, 71, 160);
            label_course_name.Location = new Point(650, 483);
            label_course_name.Name = "label_course_name";
            label_course_name.Size = new Size(157, 23);
            label_course_name.TabIndex = 52;
            label_course_name.Text = "Course Name :";
            // 
            // textBox_course_name
            // 
            textBox_course_name.Location = new Point(813, 479);
            textBox_course_name.Name = "textBox_course_name";
            textBox_course_name.Size = new Size(190, 27);
            textBox_course_name.TabIndex = 53;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score.ForeColor = Color.FromArgb(0, 71, 160);
            label_score.Location = new Point(26, 551);
            label_score.Name = "label_score";
            label_score.Size = new Size(77, 23);
            label_score.TabIndex = 54;
            label_score.Text = "Score :";
            // 
            // textBox_score
            // 
            textBox_score.Location = new Point(109, 551);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(162, 27);
            textBox_score.TabIndex = 55;
            // 
            // btn_add_score
            // 
            btn_add_score.BackColor = Color.FromArgb(0, 71, 160);
            btn_add_score.FlatStyle = FlatStyle.Flat;
            btn_add_score.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_score.ForeColor = Color.White;
            btn_add_score.Location = new Point(483, 627);
            btn_add_score.Name = "btn_add_score";
            btn_add_score.Size = new Size(166, 59);
            btn_add_score.TabIndex = 56;
            btn_add_score.Text = "Add Score";
            btn_add_score.UseVisualStyleBackColor = false;
            btn_add_score.Click += btn_add_score_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(btn_add_score);
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
            Controls.Add(btn_student_id);
            Controls.Add(dataGridView_manage);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_manage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private TextBox textBox_courseid;
        private Label label2;
        private TextBox textBox_student_id;
        private Label btn_student_id;
        private DataGridView dataGridView_manage;
        private Button btn_search;
        private ComboBox comboBox_id;
        private Label label_course_name;
        private TextBox textBox_course_name;
        private Label label_score;
        private TextBox textBox_score;
        private Button btn_add_score;
    }
}