using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintStudent : Form
    {
        student std = new student();
        DGVPrinter printer = new DGVPrinter();
        DBconnect db = new DBconnect();

        // Placeholder text constant
        private const string placeholderText = "Search by Student ID";

        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            // Show all students in the DataGridView when the form loads
            SqlCommand command = new SqlCommand("SELECT * FROM student", db.getConnection());
            showData(command);

            // Loading student IDs into the ComboBox
            fillCombo();

            // Set placeholder in the ComboBox and change color
            comboBox1.Text = placeholderText;
            comboBox1.ForeColor = Color.Gray;

            // Added to handle events (if not connected in the designer)
            comboBox1.Enter += ComboBox1_Enter;
            comboBox1.Leave += ComboBox1_Leave;
        }

        // Event to clear placeholder text when the ComboBox is clicked or focused
        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == placeholderText)
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        // Event to restore the placeholder when focus leaves the ComboBox and nothing is typed
        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                comboBox1.Text = placeholderText;
                comboBox1.ForeColor = Color.Gray;
            }
        }

        // Method to load student IDs into the ComboBox
        public void fillCombo()
        {
            SqlCommand command = new SqlCommand("SELECT StdId FROM student", db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "StdId";
            comboBox1.ValueMember = "StdId";
            comboBox1.SelectedIndex = -1;
        }

        private void dataGridView_manage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Method to display data in the DataGridView
        public void showData(SqlCommand command)
        {
            dataGridView_student_print.ReadOnly = true;
            dataGridView_student_print.RowTemplate.Height = 40;
            dataGridView_student_print.DataSource = std.getList(command);
        }

        // Search button click event
        private void btn_search_Click(object sender, EventArgs e)
        {
            // If placeholder text is in the ComboBox or it is empty, show all
            if (!string.IsNullOrWhiteSpace(comboBox1.Text) && comboBox1.Text != placeholderText)
            {
                int studentId;
                if (int.TryParse(comboBox1.Text, out studentId))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM student WHERE StdId = @id", db.getConnection());
                    command.Parameters.Add("@id", SqlDbType.Int).Value = studentId;
                    showData(command);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM student", db.getConnection());
                showData(command);
            }
        }

        // When an ID is selected from the ComboBox
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedValue != null)
            {
                int studentId;
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out studentId))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM student WHERE StdId = @id", db.getConnection());
                    command.Parameters.Add("@id", SqlDbType.Int).Value = studentId;
                    showData(command);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Student Management System - Students List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Generated by Student Management System";
            printer.FooterSpacing = 15;

            printer.printDocument.DefaultPageSettings.Landscape = true;

            foreach (System.Drawing.Printing.PaperSize paperSize in printer.printDocument.PrinterSettings.PaperSizes)
            {
                if (paperSize.PaperName == "A4")
                {
                    printer.printDocument.DefaultPageSettings.PaperSize = paperSize;
                    break;
                }
            }

            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);

            printer.PrintDataGridView(dataGridView_student_print);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Select_class_label_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void rbtn_female_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_male_CheckedChanged(object sender, EventArgs e) { }
        private void rbtn_all_CheckedChanged(object sender, EventArgs e) { }
    }
}