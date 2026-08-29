namespace StudentManagementSystem
{
    partial class printadmin
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
            comboBox_id = new ComboBox();
            btn_search = new Button();
            btn_print = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_admin_print = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin_print).BeginInit();
            SuspendLayout();
            // 
            // comboBox_id
            // 
            comboBox_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_id.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_id.FormattingEnabled = true;
            comboBox_id.Location = new Point(654, 83);
            comboBox_id.Name = "comboBox_id";
            comboBox_id.Size = new Size(300, 28);
            comboBox_id.TabIndex = 74;
            comboBox_id.SelectedIndexChanged += comboBox_id_SelectedIndexChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 71, 160);
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(973, 76);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 73;
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
            btn_print.Location = new Point(973, 689);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(94, 37);
            btn_print.TabIndex = 72;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 68);
            panel1.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(452, 17);
            label7.Name = "label7";
            label7.Size = new Size(158, 34);
            label7.TabIndex = 19;
            label7.Text = "Print Score";
            // 
            // dataGridView_admin_print
            // 
            dataGridView_admin_print.AllowUserToAddRows = false;
            dataGridView_admin_print.AllowUserToDeleteRows = false;
            dataGridView_admin_print.BackgroundColor = Color.Gainsboro;
            dataGridView_admin_print.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_admin_print.Location = new Point(14, 119);
            dataGridView_admin_print.Name = "dataGridView_admin_print";
            dataGridView_admin_print.RowHeadersWidth = 51;
            dataGridView_admin_print.RowTemplate.Height = 80;
            dataGridView_admin_print.Size = new Size(1071, 532);
            dataGridView_admin_print.TabIndex = 70;
            // 
            // printadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 759);
            Controls.Add(comboBox_id);
            Controls.Add(btn_search);
            Controls.Add(btn_print);
            Controls.Add(panel1);
            Controls.Add(dataGridView_admin_print);
            Name = "printadmin";
            Text = "printadmin";
            Load += printadmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin_print).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_id;
        private Button btn_search;
        private Button btn_print;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_admin_print;
    }
}