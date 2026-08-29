using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Course : Form
    {
        CourseClass cc = new CourseClass();
        public Course()
        {
            InitializeComponent();
            dataGridView_newcourse.RowHeadersVisible = false;
            dataGridView_newcourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox3_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox_coursename.Text == "" || textBox2_hour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                string cName = textBox_coursename.Text;
                int chr = Convert.ToInt32(textBox2_hour.Text);
                string desc = textBox3_Description.Text;


                if (cc.insertCourse(cName, chr, desc))
                {
                    showdata();
                    btn_clear.PerformClick();
                    MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course not inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_coursename.Clear();
            textBox2_hour.Clear();
            textBox3_Description.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            // To show course list on datagridview
            dataGridView_newcourse.DataSource = cc.getCourse(new SqlCommand("SELECT * FROM Courses"));

        }
    }
}
