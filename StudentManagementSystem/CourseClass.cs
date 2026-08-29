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
    public class CourseClass
    {
        // Connection object of DBconnect class
        DBconnect connect = new DBconnect();

        // Create a function to insert a course
        public bool insertCourse(string cName, int hr, string desc)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Courses (CourseName, CourseHour, Description) VALUES (@cn, @ch, @desc)", connect.getConnection());

                command.Parameters.Add("@cn", SqlDbType.VarChar).Value = cName;
                command.Parameters.Add("@ch", SqlDbType.Int).Value = hr;
                command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;

                connect.openConnect();
                int rowsAffected = command.ExecuteNonQuery();
                connect.closeConnect();

                return rowsAffected > 0;
            }
            catch (Exception)
            {
                connect.closeConnect();
                return false;
            }
        }

        // Create a function to get course list
        public DataTable getCourse(SqlCommand command)
        {
            command.Connection = connect.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Create a function to update a course
        public bool updateCourse(int id, string cName, int hr, string desc)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Courses SET CourseName = @cn, CourseHour = @ch, Description = @desc WHERE CourseId = @id", connect.getConnection());

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@cn", SqlDbType.VarChar).Value = cName;
                command.Parameters.Add("@ch", SqlDbType.Int).Value = hr;
                command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;

                connect.openConnect();
                int rowsAffected = command.ExecuteNonQuery();
                connect.closeConnect();

                return rowsAffected > 0;
            }
            catch (Exception)
            {
                connect.closeConnect();
                return false;
            }
        }

        // Create a function to delete a course
        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Courses WHERE CourseId = @id", connect.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            connect.openConnect();
            int rowsAffected = command.ExecuteNonQuery();
            connect.closeConnect();

            return rowsAffected > 0;
        }

        // Method to search specifically by ID with exact match & safe handling
        public DataTable searchCourse(string id)
        {
            DataTable table = new DataTable();

            // Return an empty table if the ID is empty or accidentally contains DataRowView
            if (string.IsNullOrEmpty(id) || id.Contains("DataRowView"))
            {
                return table;
            }

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Courses WHERE CourseId = @id", connect.getConnection());

                // int.TryParse is used to prevent crashes during conversion
                if (int.TryParse(id, out int courseId))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = courseId;
                }
                else
                {
                    return table; // If the ID is not a number
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                // To handle any exceptions
            }

            return table;
        }
    }
}