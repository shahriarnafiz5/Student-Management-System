using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace StudentManagementSystem
{
    class Admin
    {
        // Central DB connection class object
        DBconnect db = new DBconnect();

        // 1. Method to hash the password
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

        // 2. Method to auto-generate a random password
        public string GenerateRandomPassword(int length = 8)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#$%";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (length-- > 0)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        // 3. Method for new admin registration and saving to the database
        public bool InsertAdmin(string name, string phone, DateTime birthDate, string gender, string username, string hashedPassword, string address)
        {
            try
            {
                string query = @"INSERT INTO Admins (Name, Phone, BirthDate, Gender, Username, Password, Address) 
                                 VALUES (@Name, @Phone, @BirthDate, @Gender, @Username, @Password, @Address)";

                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@Address", address);

                db.openConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting admin: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
        }

        // Method to update existing admin details
        public bool UpdateAdmin(int id, string name, string phone, DateTime birthDate, string gender, string username, string hashedPassword, string address)
        {
            try
            {
                string query = @"UPDATE Admins 
                         SET Name = @Name, 
                             Phone = @Phone, 
                             BirthDate = @BirthDate, 
                             Gender = @Gender, 
                             Username = @Username, 
                             Password = @Password, 
                             Address = @Address 
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@Address", address);

                db.openConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating admin: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
        }

        // Method to update corresponding user info in the Users table
        public bool UpdateUser(string oldUsername, string newUsername, string hashedPassword)
        {
            try
            {
                string query = "UPDATE Users SET Username = @newUsername, Password = @password WHERE Username = @oldUsername";

                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@newUsername", newUsername);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@oldUsername", oldUsername);

                db.openConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
        }

        // 4. Method to load all admin data for displaying in the DataGridView
        public DataTable GetAllAdmins()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT Id, Name, Phone, BirthDate, Gender, Username, Password, Address FROM Admins";
                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                db.openConnect();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading admin data: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
            return dt;
        }

        // 5. Method to delete a specific admin from the Admins table based on Id
        public bool DeleteAdmin(int id)
        {
            try
            {
                string query = "DELETE FROM Admins WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Id", id);

                db.openConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting admin: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
        }

        // Method to delete corresponding user from the Users table based on Username
        public bool DeleteUser(string username)
        {
            try
            {
                string query = "DELETE FROM Users WHERE Username = @Username";

                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Username", username);

                db.openConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user: " + ex.Message);
            }
            finally
            {
                db.closeConnect();
            }
        }

        // Admin.cs ক্লাসে এই মেথডটি যোগ করুন
        public bool ValidateAdminLogin(string username, string hashedPassword)
        {
            // সঠিক কানেকশন স্ট্রিং এখানে সেট করে দেওয়া হলো
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Admins WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // যদি কাউন্ট ১ হয়, তার মানে ইউজারনেম ও পাসওয়ার্ড সঠিক আছে
                    return count == 1;
                }
            }
        }

    }
}