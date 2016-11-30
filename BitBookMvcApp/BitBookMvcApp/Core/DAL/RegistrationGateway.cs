using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BitBookMVCApp.Models;
using BitBookMVCApp.ViewModels;
using BitBookMVCApp.ViewModels.Registration;

namespace BitBookMVCApp.Core.DAL
{
    public class RegistrationGateway
    {
        private readonly string connectionString =
            WebConfigurationManager.ConnectionStrings["BitBookDBConnectionString"].ConnectionString;



        public int InsertUser(User user)
        {
            var connection = new SqlConnection(connectionString);

            var query = "INSERT INTO Users(Email, Password) VALUES(@Email, @Password)";
            //            var query1 = "INSERT INTO User(Email, Password) VALUES('"+user.Email+"','"+user.Password+"')";
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

        public int InsertProfile(Profile profile)
        {
            var connection = new SqlConnection(connectionString);

            var query = "INSERT INTO Profile (FirstName, LastName, DOB, Gender, CreateDate, UserId) values(@FirstName, @LastName, @DateOfBirth, @Gender, @CreateDate, @UserId)";
            var command = new SqlCommand(query, connection);

            command.Parameters.Clear();

            command.Parameters.Add("@FirstName", SqlDbType.VarChar);
            command.Parameters["@FirstName"].Value = profile.FirstName;

            command.Parameters.Add("@LastName", SqlDbType.VarChar);
            command.Parameters["@LastName"].Value = profile.LastName;

            command.Parameters.Add("@DateOfBirth", SqlDbType.Date);
            command.Parameters["@DateOfBirth"].Value = profile.DateOfBirth;

            command.Parameters.Add("@Gender", SqlDbType.VarChar);
            command.Parameters["@Gender"].Value = profile.Gender;

            command.Parameters.Add("@CreateDate", SqlDbType.Date);
            command.Parameters["@CreateDate"].Value = profile.CreateDate;

            command.Parameters.Add("@UserId", SqlDbType.Int);
            command.Parameters["@UserId"].Value = profile.UserId;

            connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
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
    }
}