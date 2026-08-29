using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class printadmin : Form
    {
        Admin adminClass = new Admin();

        public printadmin()
        {
            InitializeComponent();
            this.Load += new EventHandler(printadmin_Load);
        }

        private void printadmin_Load(object sender, EventArgs e)
        {
            LoadAdminGrid();
            LoadAdminIdsToComboBox();
        }

        // Method to load all admin information into the DataGridView
        private void LoadAdminGrid()
        {
            try
            {
                dataGridView_admin_print.DataSource = adminClass.GetAllAdmins();
                dataGridView_admin_print.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_admin_print.RowHeadersVisible = false;
                dataGridView_admin_print.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_admin_print.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Method to load IDs into the ComboBox
        private void LoadAdminIdsToComboBox()
        {
            try
            {
                DataTable dt = adminClass.GetAllAdmins();
                comboBox_id.DataSource = dt;
                comboBox_id.DisplayMember = "Id";
                comboBox_id.ValueMember = "Id";
                comboBox_id.SelectedIndex = -1;   // Keep this at the very end
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading IDs: " + ex.Message);
            }
        }

        // Logic to show specific admin info when selected from the ComboBox
        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedIndex != -1 && comboBox_id.SelectedValue != null)
            {
                if (comboBox_id.SelectedValue is DataRowView)
                {
                    return;
                }

                try
                {
                    string selectedId = comboBox_id.SelectedValue.ToString();
                    DataTable dt = adminClass.GetAllAdmins();

                    // Create a new table and filter only the row with the specific ID
                    DataTable filteredDt = dt.Clone();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Id"].ToString() == selectedId)
                        {
                            filteredDt.ImportRow(row);
                        }
                    }

                    dataGridView_admin_print.DataSource = filteredDt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
            }
        }

        // Search button click event
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBox_id.Text))
            {
                MessageBox.Show("Please select or type an ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = adminClass.GetAllAdmins();
                string searchId = comboBox_id.Text.Trim();

                DataTable filteredDt = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Id"].ToString() == searchId)
                    {
                        filteredDt.ImportRow(row);
                    }
                }

                if (filteredDt.Rows.Count > 0)
                {
                    dataGridView_admin_print.DataSource = filteredDt;
                }
                else
                {
                    MessageBox.Show("No admin found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAdminGrid(); // Reload all data if not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error performing search: " + ex.Message);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Create DGVPrinter object
            DGVPrinter printer = new DGVPrinter();

            // Header and title settings (tailored for admin report)
            printer.Title = "Admin Information Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            // Page numbers and alignment
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            // Footer settings
            printer.Footer = "Student Management System - Admin Module";
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

            // 3. Main command to print the DataGridView (prints from dataGridView_admin_print)
            printer.PrintDataGridView(dataGridView_admin_print);
        }
    }
}