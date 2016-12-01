using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string AComment { get; set; }
        public int PostId { get; set; }
        public DateTime Time { get; set; }
        public int WhoCommentedId { get; set; }
    }
}