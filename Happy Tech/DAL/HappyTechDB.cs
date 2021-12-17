using Happy_Tech.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech.DAL
{
    class HappyTechDB
    {
        private static SqlConnection GetConnection()
        {
            string sql = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\HappyTech.mdf; Integrated Security= True";
            SqlConnection connection = new SqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL connection error!" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static bool IsValidNamePass(string name, string password)
        {
            try
            {
                string sql = "SELECT User_Name, User_Password FROM Users WHERE User_Name = '" + name + "' AND User_Password = '" + password + "';";
                SqlConnection conn = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sdp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdp.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                    return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Username and password error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void AddUser(User user)
        {
            string sql = "INSERT INTO Users VALUES (@Username, @Password);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("User already added.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateUser(User user, string id)
        {
            string sql = "UPDATE Users SET User_Name = @Name, User_Password = @Password WHERE User_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("User not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteUser(string Id)
        {
            string sql = "DELETE FROM Users WHERE User_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("User not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            conn.Close();
        }

        public static void AddTemplate(Template template)
        {
            string sql = "INSERT INTO Templates VALUES (@Name, @One, @Two, @Three);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = template.TemplateName;
            command.Parameters.Add("@One", SqlDbType.VarChar).Value = template.Section1;
            command.Parameters.Add("@Two", SqlDbType.VarChar).Value = template.Section2;
            command.Parameters.Add("@Three", SqlDbType.VarChar).Value = template.Section3;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Template already added.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Template not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateTemplate(Template template, string id)
        {
            string sql = "UPDATE Templates SET Template_Name = @Name, Section_One = @One, Section_Two = @Two, Section_Three = @Three WHERE Template_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = template.TemplateName;
            command.Parameters.Add("@One", SqlDbType.VarChar).Value = template.Section1;
            command.Parameters.Add("@Two", SqlDbType.VarChar).Value = template.Section2;
            command.Parameters.Add("@Three", SqlDbType.VarChar).Value = template.Section3;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Template not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteTemplate(string Id)
        {
            string sql = "DELETE FROM Templates WHERE Template_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Template not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddCode(Code code)
        {
            string sql = "INSERT INTO Codes VALUES (@Title, @Body);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Title", SqlDbType.VarChar).Value = code.CodeTitle;
            command.Parameters.Add("@Body", SqlDbType.VarChar).Value = code.CodeBody;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Code already added.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Code not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateCode(Code code, string id)
        {
            string sql = "UPDATE Codes SET Code_Title = @Title, Code_Body = @Body WHERE Code_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Title", SqlDbType.VarChar).Value = code.CodeTitle;
            command.Parameters.Add("@Body", SqlDbType.VarChar).Value = code.CodeBody;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Code not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteCode(string Id)
        {
            string sql = "DELETE FROM Codes WHERE Code_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Code not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void FillComboBox(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                    cb.Items.Add(sdr[0]);
            }
            catch (SqlException)
            {
                MessageBox.Show("Template or code not finded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private static int GetId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Template or code id not finded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static void AddFeedback(Feedback feedback)
        {
            string sql = "INSERT INTO Feedbacks VALUES (@Name, @Email, @Template, @Code, @Text);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = feedback.Name;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = feedback.Eamil;
            command.Parameters.Add("@Template", SqlDbType.Int).Value = GetId("SELECT Template_Id FROM Templates WHERE Template_Name = '" + feedback.Template + "';");
            command.Parameters.Add("@Code", SqlDbType.Int).Value = GetId("SELECT Code_Id FROM Codes WHERE Code_Title = '" + feedback.Code + "';");
            command.Parameters.Add("@Text", SqlDbType.VarChar).Value = feedback.Text;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Applicant already added.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Applicant not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateFeedback(Feedback feedback, string id)
        {
            string sql = "UPDATE Feedbacks SET Applicant_Name = @Name, Applicant_Email = @Email, Feedback_Template_Id = @Template, Feedback_Code_Id = @Code, Applicant_Free_Text = @Text WHERE Feedback_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = feedback.Name;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = feedback.Eamil;
            command.Parameters.Add("@Template", SqlDbType.Int).Value = GetId("SELECT Template_Id FROM Templates WHERE Template_Name = '" + feedback.Template + "';");
            command.Parameters.Add("@Code", SqlDbType.Int).Value = GetId("SELECT Code_Id FROM Codes WHERE Code_Title = '" + feedback.Code + "';");
            command.Parameters.Add("@Text", SqlDbType.VarChar).Value = feedback.Text;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Applicant not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteFeedback(string Id)
        {
            string sql = "DELETE FROM Feedbacks WHERE Feedback_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Removed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Applicant not deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int Count(string query)
        {
            int rows = 0;
            SqlConnection connection = GetConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                rows = (int)cmd.ExecuteScalar();
                return rows;
            }
            catch (SqlException)
            {
            }
            connection.Close();
            return rows;
        }
    }
}
