using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVCApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string UsersPost { get; set; }
        public bool isText { get; set; }
        public bool isPic { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}