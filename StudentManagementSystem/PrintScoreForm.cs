using DGVPrinterHelper;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class PrintScoreForm : Form
    {
        Score scoreClass = new Score();

        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load unique student IDs into the combobox using the Score class
                scoreClass.LoadStudentIdsToComboBox(comboBox_id);
                dataGridView_score_print.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to load courses and scores for a specific student
        private void LoadStudentCourses(int stdId)
        {
            try
            {
                DataTable dt = scoreClass.GetStudentCourses(stdId);
                dataGridView_score_print.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Remove placeholder when the combobox receives focus
        private void comboBox_id_Enter(object sender, EventArgs e)
        {
            if (comboBox_id.Text == "Search or Select Student id")
            {
                comboBox_id.Text = "";
            }
        }

        // Restore placeholder when the combobox loses focus
        private void comboBox_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                comboBox_id.Text = "Search or Select Student id";
            }
        }

        // Automatically load courses and scores when an ID is selected from the combobox
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedIndex == -1 || comboBox_id.SelectedValue == null)
                return;

            int selectedStdId;
            if (!int.TryParse(comboBox_id.SelectedValue.ToString(), out selectedStdId))
                return;

            LoadStudentCourses(selectedStdId);
        }

        // Search button click event (searches using the ID selected or typed in the combobox)
        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchIdText = "";

            if (comboBox_id.SelectedValue != null && !string.IsNullOrEmpty(comboBox_id.SelectedValue.ToString()))
            {
                searchIdText = comboBox_id.SelectedValue.ToString();
            }
            else if (comboBox_id.SelectedItem != null)
            {
                searchIdText = comboBox_id.SelectedItem.ToString();
            }
            else if (!string.IsNullOrEmpty(comboBox_id.Text) && comboBox_id.Text != "Search or Select Student id")
            {
                searchIdText = comboBox_id.Text;
            }
            else
            {
                MessageBox.Show("Please select or type an ID in the combobox!");
                return;
            }

            int searchStdId;
            if (!int.TryParse(searchIdText, out searchStdId))
            {
                MessageBox.Show("Please provide a valid student ID!");
                return;
            }

            LoadStudentCourses(searchStdId);
        }

        private void dataGridView_score_print_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_score_print_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Create DGVPrinter object
            DGVPrinter printer = new DGVPrinter();

            // Header and title settings
            printer.Title = "Student Score Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            // Page numbers and alignment
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            // Footer settings
            printer.Footer = "Student Management System";
            printer.FooterSpacing = 15;

            // 1. Set the print page to Landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;

            // 2. Set the page size to A4
            foreach (System.Drawing.Printing.PaperSize paperSize in printer.printDocument.PrinterSettings.PaperSizes)
            {
                if (paperSize.PaperName == "A4")
                {
                    printer.printDocument.DefaultPageSettings.PaperSize = paperSize;
                    break;
                }
            }

            // 3. Set margins (Left, Top, Right, Bottom)
            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);

            // Call to print or preview the DataGridView (using the correct DataGridView name here)
            printer.PrintDataGridView(dataGridView_score_print);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}