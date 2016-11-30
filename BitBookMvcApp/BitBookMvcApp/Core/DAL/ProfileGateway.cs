using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BitBookMVCApp.Models;

namespace BitBookMVCApp.Core.DAL
{
    public class ProfileGateway
    {
        private readonly string connectionString =
            WebConfigurationManager.ConnectionStrings["BitBookDBConnectionString"].ConnectionString;

        public Profile GetProfileByUserId(int userId)
        {
            var connection = new SqlConnection(connectionString);
            Profile profile = null;
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string firstName = Convert.ToString(reader["FirstName"]);
                string lastName = Convert.ToString(reader["LastName"]);
                DateTime dateOfBirth = Convert.ToDateTime(reader["DOB"]);
                string gender = Convert.ToString(reader["Gender"]);
                int proPicId = 0;
                if (!(reader["ProPicId"] is DBNull))
                {
                    proPicId = Convert.ToInt32(reader["ProPicId"]);
                }
                int coverPicId = 0;
                if (!(reader["CoverPicId"] is DBNull))
                {
                    coverPicId = Convert.ToInt32(reader["CoverPicId"]);
                }
                string religion = Convert.ToString(reader["Religion"]);
                bool hasRelationship = false;
                if (!(reader["HasRelationship"] is DBNull))
                {
                    hasRelationship = Convert.ToBoolean(reader["HasRelationship"]);
                }
                string relationship = Convert.ToString(reader["Relationship"]);
                int relationshipWithId = 0;
                if (!(reader["RelationshipWithId"] is DBNull))
                {
                    relationshipWithId = Convert.ToInt32(reader["RelationshipWithId"]);
                }
                string about = Convert.ToString(reader["About"]);
                DateTime createDate = Convert.ToDateTime(reader["CreateDate"]);
                int dbUserId = Convert.ToInt32(reader["UserId"]);

                profile = new Profile(id, firstName, lastName, dateOfBirth, gender, proPicId, coverPicId, religion, hasRelationship, relationship, relationshipWithId, about, createDate, dbUserId);
            }

            reader.Close();
            connection.Close();
            return profile;
        }

        public int UpdateName(int userId, string firstName, string lastName)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int UpdateProPicId(int userId, int proPicId)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int UpdateCoverPicId(int userId, int coverPicId)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int UpdateReligion(int userId, string religion)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int UpdateRelationship(int userId, bool hasRelationship, string relationship, int relationshipWithId)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public int UpdateAbout(int userId, string about)
        {
            var connection = new SqlConnection(connectionString);
            var qrey = "SELECT * FROM Profile WHERE UserId='" + userId + "'";
            var command = new SqlCommand(qrey, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}