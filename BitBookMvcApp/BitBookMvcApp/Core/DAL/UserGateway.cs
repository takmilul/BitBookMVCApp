using System;
using System.Collections.Generic;
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

        public List<Registration> GetAllUsers()
        {
            var connection = new SqlConnection(connectionString);

            List<Registration> userList = null;
            var qrey = "SELECT * FROM Users";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                userList = new List<Registration>();
                var user = new Registration
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = Convert.ToString(reader["FirstName"]),
                    LastName = Convert.ToString(reader["LastName"]),
                    Email = Convert.ToString(reader["Email"]),
                    Password = Convert.ToString(reader["Password"]),
                    DateOfBirth = Convert.ToDateTime(reader["DOB"]),
                    Gender = Convert.ToString(reader["Gender"])
                };

                userList.Add(user);
            }
            reader.Close();
            connection.Close();
            return userList;
        }

        public User GetListofUserByProfileId(int proifleId)
        {
            return null;
        }
    }
}