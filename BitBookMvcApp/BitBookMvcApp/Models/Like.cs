using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int WhoLikedId { get; set; }
        public string FullName { get; set; }
        public string ProPicUrl { get; set; }
        public int TotalLike { get; set; }
    }
}