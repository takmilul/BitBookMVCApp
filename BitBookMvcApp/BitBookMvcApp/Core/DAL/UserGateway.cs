using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BitBookMVCApp.Models;
using BitBookMVCApp.ViewModels.Registration;

namespace BitBookMVCApp.Core.DAL
{
    public class UserGateway
    {
        private readonly string connectionString =
            WebConfigurationManager.ConnectionStrings["BitBookDBConnectionString"].ConnectionString;

        public int InsertUser(User user)
        {
            var connection = new SqlConnection(connectionString);

            var query = "INSERT INTO Users(Email, Password) VALUES(@Email, @Password)";
            
            var command = new SqlCommand(query, connection);

            command.Parameters.Clear();

            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters["@Email"].Value = user.Email;

            command.Parameters.Add("@Password", SqlDbType.VarChar);
            command.Parameters["@Password"].Value = user.Password;

            connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public User GetUserById(int id)
        {
            var connection = new SqlConnection(connectionString);

            User user = null;
            var qrey = "SELECT * FROM Users WHERE Id=@Id";
            var command = new SqlCommand(qrey, connection);
            command.Parameters.Clear();
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters["@Id"].Value = id;
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Email = Convert.ToString(reader["Email"]),
                    Password = Convert.ToString(reader["Password"])
                };
            }
            reader.Close();
            connection.Close();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            var connection = new SqlConnection(connectionString);

            User user = null;
            var qrey = "SELECT * FROM Users WHERE Email='" + email + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Email = Convert.ToString(reader["Email"]),
                    Password = Convert.ToString(reader["Password"])
                };
            }
            reader.Close();
            connection.Close();
            return user;
        }

        public List<User> GetAllUsers()
        {
            var connection = new SqlConnection(connectionString);

            List<User> userList = null;
            var qrey = "SELECT * FROM Users";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                userList = new List<User>();
                var user = new User()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Email = Convert.ToString(reader["Email"]),
                    Password = Convert.ToString(reader["Password"])
                };

                userList.Add(user);
            }
            reader.Close();
            connection.Close();
            return userList;
        }

        public int ChangePassword(string newPassword, int userId)
        {
            var connection = new SqlConnection(connectionString);

            var query = "UPDATE Users SET Password=@Password WHERE Id=@Id";
            var command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters["@Id"].Value = userId;
            command.Parameters.Add("@Password", SqlDbType.VarChar);
            command.Parameters["@Password"].Value = newPassword;

            connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}