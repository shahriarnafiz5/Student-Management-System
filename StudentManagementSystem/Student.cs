using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; // Required for SQL Server namespace
using System.Security.Cryptography; // Required for password hashing

namespace StudentManagementSystem
{
    class student
    {
        DBconnect connect = new DBconnect();

        // A function to hash the password (SHA256)
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Create a function to insert a student (Username and hashed password included, photo excluded)
        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, string username, string password)
        {
            // Hashing the password
            string hashedPassword = HashPassword(password);

            SqlCommand command = new SqlCommand("INSERT INTO student (StdFirstName, StdLastName, Birthdate, Gender, Phone, Address, username, password) VALUES (@fn, @ln, @bd, @gd, @ph, @adr, @usr, @pwd)", connect.getConnection());

            // Adding the parameters
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@usr", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = hashedPassword;

            // Opening the database connection
            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
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

        // To get the student list table
        public DataTable getStudentlist()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM student", connect.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // Create a function to execute the count query (total, male, female)
        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, (SqlConnection)connect.getConnection());
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // To get the total students count
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }

        // To get the male students count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Male'");
        }

        // To get the female students count
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender = 'Female'");
        }

        // Function to search for a student
        public DataTable searchStudent(string searchdata)
        {
            // Updated search query including username and excluding photo
            string query = "SELECT * FROM student WHERE CONCAT(StdId, StdFirstName, StdLastName, Address, username) LIKE @search";

            SqlCommand command = new SqlCommand(query, connect.getConnection());

            // Adding the search parameter
            command.Parameters.Add("@search", SqlDbType.VarChar).Value = "%" + searchdata + "%";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        // Create a function to update a student (Username and password update included, photo excluded)
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, string username, string password)
        {
            string hashedPassword = HashPassword(password);

            SqlCommand command = new SqlCommand("UPDATE student SET StdFirstName = @fn, StdLastName = @ln, Birthdate = @bd, Gender = @gd, Phone = @ph, Address = @adr, username = @usr, password = @pwd WHERE StdId = @id", connect.getConnection());

            // Adding the parameters
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@usr", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = hashedPassword;

            // Opening the database connection
            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
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

        // Create a function for any generic command in studentDb
        public DataTable getList(SqlCommand command)
        {
            command.Connection = connect.getConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Function to delete a student by ID
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE StdId = @id", connect.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
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

        // Function to validate student login credentials
        public bool ValidateStudentLogin(string username, string password)
        {
            // Hashing the input password because passwords are saved as hashed values in the database
            string hashedPassword = HashPassword(password);

            // Query according to the correct table and column names (student, username, password)
            SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM student WHERE username = @usr AND password = @pwd", connect.getConnection());

            command.Parameters.Add("@usr", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = hashedPassword;

            connect.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.closeConnect();

            // Returns true if the count is 1, indicating matching credentials
            return count == 1;
        }
    }
}