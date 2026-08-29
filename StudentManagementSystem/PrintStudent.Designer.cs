namespace StudentManagementSystem
{
    partial class PrintStudent
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
            dataGridView_student_print = new DataGridView();
            btn_print = new Button();
            btn_search = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student_print).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 68);
            panel1.TabIndex = 44;
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
            // dataGridView_student_print
            // 
            dataGridView_student_print.AllowUserToAddRows = false;
            dataGridView_student_print.AllowUserToDeleteRows = false;
            dataGridView_student_print.BackgroundColor = Color.Gainsboro;
            dataGridView_student_print.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student_print.Location = new Point(12, 117);
            dataGridView_student_print.Name = "dataGridView_student_print";
            dataGridView_student_print.RowHeadersWidth = 51;
            dataGridView_student_print.RowTemplate.Height = 80;
            dataGridView_student_print.Size = new Size(1071, 532);
            dataGridView_student_print.TabIndex = 43;
            dataGridView_student_print.CellContentClick += dataGridView_manage_CellContentClick;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(0, 71, 160);
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_print.ForeColor = Color.White;
            btn_print.Location = new Point(943, 700);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(94, 37);
            btn_print.TabIndex = 52;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 71, 160);
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(971, 74);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 53;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(699, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(comboBox1);
            Controls.Add(btn_search);
            Controls.Add(btn_print);
            Controls.Add(panel1);
            Controls.Add(dataGridView_student_print);
            Name = "PrintStudent";
            Text = "PrintStudent";
            Load += PrintStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student_print).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_student_print;
        private Button btn_print;
        private Button btn_search;
        private ComboBox comboBox1;
    }
}