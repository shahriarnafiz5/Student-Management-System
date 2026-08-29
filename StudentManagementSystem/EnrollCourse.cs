using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    internal class CourseEnrollment
    {
        DBconnect connect = new DBconnect();

        // Create a function to insert student course enrollment
        public bool insertStudentCourse(int stdId, int courseId)
        {
            // SqlCommand and SqlParameter are used for SQL Server
            // CourseName is automatically fetched from the Courses table and saved into the StudentCourses table
            SqlCommand command = new SqlCommand("INSERT INTO StudentCourses (StdId, CourseId, CourseName) SELECT @stdId, @courseId, CourseName FROM Courses WHERE CourseId = @courseId", connect.getConnection());

            // Adding the parameters
            command.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;
            command.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;

            // Opening the database connection
            connect.openConnect();

            // If the query executes successfully, one or more rows will be affected
            if (command.ExecuteNonQuery() > 0)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getStudentCourseList()
        {
            // Fetching data from the StudentCourses table using SqlCommand and SqlDataAdapter
            SqlCommand command = new SqlCommand("SELECT * FROM StudentCourses", connect.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentCoursesById(int stdId)
        {
            // Query to fetch records matching the specific Student ID
            SqlCommand command = new SqlCommand("SELECT * FROM StudentCourses WHERE StdId = @stdId", connect.getConnection());
            command.Parameters.Add("@stdId", SqlDbType.Int).Value = stdId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}