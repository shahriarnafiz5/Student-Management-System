using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentPortal : Form
    {
        private Form activeForm = null;

        private string loggedInUsername;

        public StudentPortal(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        public StudentPortal()
        {
            InitializeComponent();
        }

        // Common method to open a child form
        private void openChildForm(Form childForm)
        {
            // If any form is already open, close it
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Clear all existing controls (header, footer, pictures, etc.) inside the panel
            panelChildForm.Controls.Clear();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the new form to the panel
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_show_information_Click(object sender, EventArgs e)
        {
            // Passing loggedInUsername to the ShowInformation form via the constructor
            ShowInformation infoForm = new ShowInformation(loggedInUsername);
            openChildForm(infoForm);
        }

        private void btn_show_score_Click(object sender, EventArgs e)
        {
            ShowScoreForm scoreForm = new ShowScoreForm(loggedInUsername);
            openChildForm(scoreForm);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            // 1. If any child form (Information or Score) is open, close it
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // 2. Clear all controls from the panel
            panelChildForm.Controls.Clear();

            // 3. Add the original dashboard controls or panels back to the panel
            panelChildForm.Controls.Add(panel6);
            panelChildForm.Controls.Add(panel1);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Controls.Add(panel8);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // To completely close and exit the application or project
            Application.Exit();
        }
    }
}