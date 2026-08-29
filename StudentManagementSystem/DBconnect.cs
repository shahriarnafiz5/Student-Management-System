using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    class DBconnect
    {
        // SQL Server connection string
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True");

        // 1. getConnection method
        public SqlConnection getConnection()
        {
            return con;
        }

        // 2. openConnect method
        public void openConnect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // 3. closeConnect method
        public void closeConnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}