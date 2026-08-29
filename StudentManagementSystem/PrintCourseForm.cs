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
    public partial class PrintCourseForm : Form
    {
        CourseClass cc = new CourseClass();
        DBconnect connect = new DBconnect();
        DGVPrinter printer = new DGVPrinter();

        public PrintCourseForm()
        {
            InitializeComponent();
            dataGridView_course_print.RowHeadersVisible = false;
            dataGridView_course_print.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            showdata();
            fillCourseCombo();
        }

        private void showdata()
        {
            dataGridView_course_print.DataSource = cc.getCourse(new SqlCommand("SELECT * FROM Courses"));
        }

        // কোর্স আইডি কম্বোবক্সে লোড করা এবং ডিফল্ট টেক্সট সেট করা
        public void fillCourseCombo()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT CourseId FROM Courses", connect.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBox_id.DataSource = table;
                comboBox_id.DisplayMember = "CourseId";
                comboBox_id.ValueMember = "CourseId";
                comboBox_id.SelectedIndex = -1;
                comboBox_id.Text = "Search by Course Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // কম্বোবক্সে ক্লিক করলে বা ফোকাস পেলে লেখা মুছে যাওয়ার জন্য
        private void comboBox_id_Enter(object sender, EventArgs e)
        {
            if (comboBox_id.Text == "Search by Course Id")
            {
                comboBox_id.Text = "";
            }
        }

        // কম্বোবক্স খালি থাকলে প্লেসহোল্ডার ফিরিয়ে আনার জন্য
        private void comboBox_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                comboBox_id.Text = "Search by Course Id";
            }
        }

        // Search Button Functionality (কম্বোবক্সে লিখে বা সিলেক্ট করে সার্চ বাটনে ক্লিক করলে কাজ করবে)
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchVal = comboBox_id.Text.Trim();

            if (searchVal == "" || searchVal == "Search by Course Id")
            {
                MessageBox.Show("Please enter or select a Course ID", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showdata();
                return;
            }

            DataTable dt = cc.searchCourse(searchVal);
            if (dt.Rows.Count > 0)
            {
                dataGridView_course_print.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No course found with this ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_course_print.DataSource = null;
            }
        }

        // ComboBox SelectedIndexChanged (ড্রপডাউন থেকে সিলেক্ট করলে অটোমেটিক ফিল্টার হবে)
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedIndex != -1 && comboBox_id.SelectedValue != null)
            {
                string id = comboBox_id.SelectedValue.ToString();
                DataTable dt = cc.searchCourse(id);
                if (dt.Rows.Count > 0)
                {
                    dataGridView_course_print.DataSource = dt;
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Mdemy Courses list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "foxlearn";
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

            printer.PrintDataGridView(dataGridView_course_print);
        }

        private void textBox_print_course_TextChanged(object sender, EventArgs e) { }
        private void dataGridView_student_print_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}