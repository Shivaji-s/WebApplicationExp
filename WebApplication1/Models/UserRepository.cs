using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.Models
{
    public class UserRepository
    {

        // private string _connectionString = "Data source=LAPTOP-LSD648LN;Initial Catalog=Users;Integrated Security=True;";

        private string _connectionString = ConfigurationManager.ConnectionStrings["UsersConnection"].ToString();

        public UserRepository()
        {
            
        }

        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Userss (UserName, Email, Password, Age) VALUES (@UserName, @Email, @Password, @Age)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Age", user.Age);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

      /*  public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])
                    });
                }
            }

            return users;
        }

        public User GetUserByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])
                    };
                }
            }

            return null;
        }

        public void DeleteUser(string email)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Users SET UserName = @UserName, Password = @Password, Age = @Age WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Age", user.Age);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        } */
    }
}
