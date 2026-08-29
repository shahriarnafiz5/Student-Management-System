using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class Score
    {
        // Database connection string
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=StudentDB;Integrated Security=True;";

        // 1. Method to load unique student IDs for the ComboBox
        public DataTable GetStudentIds()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT StdId FROM StudentCourses";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading IDs: " + ex.Message);
                }
            }
            return dt;
        }

        // 2. Method to load courses and scores for a specific student ID
        public DataTable GetStudentCourses(int stdId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            sc.StdId,
                            sc.CourseId, 
                            sc.CourseName, 
                            ISNULL(CAST(s.Score AS VARCHAR(10)), '---') AS Score
                        FROM StudentCourses sc
                        LEFT JOIN Scores s ON sc.StdId = s.StdId AND sc.CourseId = s.CourseId
                        WHERE sc.StdId = @StdId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StdId", stdId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
            return dt;
        }

        // Method to insert score (including duplicate check)
        public bool InsertScore(int stdId, int courseId, decimal score)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the score for this course has already been entered for this student
                    string checkQuery = "SELECT COUNT(*) FROM Scores WHERE StdId = @StdId AND CourseId = @CourseId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@StdId", stdId);
                    checkCmd.Parameters.AddWithValue("@CourseId", courseId);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // If score already exists, throw an exception or return false
                        throw new Exception("The score for this course has already been entered for this student!");
                    }

                    // If not, perform a new entry (INSERT)
                    string query = "INSERT INTO Scores (StdId, CourseId, Score) VALUES (@StdId, @CourseId, @Score)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StdId", stdId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@Score", score);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public bool UpdateScore(int stdId, int courseId, decimal score)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // First check if the score for this course exists in the database for this student
                    string checkQuery = "SELECT COUNT(*) FROM Scores WHERE StdId = @StdId AND CourseId = @CourseId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@StdId", stdId);
                    checkCmd.Parameters.AddWithValue("@CourseId", courseId);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // If the score does not exist beforehand, it cannot be updated
                        throw new Exception("No score found for this course and student, please enter it first!");
                    }

                    // If the score exists, update it
                    string query = "UPDATE Scores SET Score = @Score WHERE StdId = @StdId AND CourseId = @CourseId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StdId", stdId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@Score", score);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void LoadStudentIdsToComboBox(ComboBox comboBox)
        {
            try
            {
                DataTable dt = GetStudentIds(); // Your previous method to fetch data
                comboBox.DataSource = dt;
                comboBox.DisplayMember = "StdId";
                comboBox.ValueMember = "StdId";

                comboBox.SelectedIndex = -1; // No ID will be selected initially
                comboBox.Text = "Search or Select Student id";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}