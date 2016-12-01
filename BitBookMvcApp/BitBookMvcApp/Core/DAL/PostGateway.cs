using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BitBookMVCApp.Models;

namespace BitBookMvcApp.Core.DAL
{
    public class PostGateway
    {
        private readonly string connectionString =
            WebConfigurationManager.ConnectionStrings["BitBookDBConnectionString"].ConnectionString;

        public int AddPost(Post post)
        {
            var connection = new SqlConnection(connectionString);
            var query = "SP_AddPost";
            var command = new SqlCommand(query, connection){CommandType = CommandType.StoredProcedure};
            command.Parameters.Clear();
            command.Parameters.Add("@Post", SqlDbType.VarChar);
            command.Parameters["@Post"].Value = post.UsersPost;
            command.Parameters.Add("@PicUrl", SqlDbType.VarChar);
            command.Parameters["@PicUrl"].Value = post.PicUrl;
            command.Parameters.Add("@IsText", SqlDbType.Bit);
            command.Parameters["@IsText"].Value = post.isText;
            command.Parameters.Add("@IsPic", SqlDbType.Bit);
            command.Parameters["@IsPic"].Value = post.isPic;
            command.Parameters.Add("@Date", SqlDbType.DateTime);
            command.Parameters["@Date"].Value = post.Date;
            command.Parameters.Add("@UserId", SqlDbType.Int);
            command.Parameters["@UserId"].Value = post.UserId;
            connection.Open();
            int postId = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return postId;
        }

        public int RemovePost(Post post)
        {
            var connection = new SqlConnection(connectionString);
            var query = "DELETE FROM Post WHERE Id=@Id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters["@Id"].Value = post.Id;
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}