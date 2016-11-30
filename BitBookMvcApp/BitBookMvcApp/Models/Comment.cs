using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVCApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public DateTime Date { get; set; }
        public int WhoCommentedId { get; set; }
    }
}