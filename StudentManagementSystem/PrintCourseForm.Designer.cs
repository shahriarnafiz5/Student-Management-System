namespace StudentManagementSystem
{
    partial class PrintCourseForm
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
            btn_print = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_course_print = new DataGridView();
            comboBox_id = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course_print).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 71, 160);
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(973, 85);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 63;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(0, 71, 160);
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_print.ForeColor = Color.White;
            btn_print.Location = new Point(973, 698);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(94, 37);
            btn_print.TabIndex = 62;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 68);
            panel1.TabIndex = 55;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(410, 17);
            label7.Name = "label7";
            label7.Size = new Size(110, 34);
            label7.TabIndex = 19;
            label7.Text = "To Print";
            // 
            // dataGridView_course_print
            // 
            dataGridView_course_print.AllowUserToAddRows = false;
            dataGridView_course_print.AllowUserToDeleteRows = false;
            dataGridView_course_print.BackgroundColor = Color.Gainsboro;
            dataGridView_course_print.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_course_print.Location = new Point(14, 128);
            dataGridView_course_print.Name = "dataGridView_course_print";
            dataGridView_course_print.RowHeadersWidth = 51;
            dataGridView_course_print.RowTemplate.Height = 80;
            dataGridView_course_print.Size = new Size(1071, 532);
            dataGridView_course_print.TabIndex = 54;
            dataGridView_course_print.CellContentClick += dataGridView_student_print_CellContentClick;
            // 
            // comboBox_id
            // 
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(709, 92);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(243, 28);
            comboBox_id.TabIndex = 64;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(comboBox_id);
            Controls.Add(btn_search);
            Controls.Add(btn_print);
            Controls.Add(panel1);
            Controls.Add(dataGridView_course_print);
            Name = "PrintCourseForm";
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course_print).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_search;
        private Button btn_print;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_course_print;
        private ComboBox comboBox_id;
    }
}