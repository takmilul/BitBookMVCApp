using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class FriendList
    {
        public int Id { get; set; }
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public string FriendName { get; set; }
        public string ProPicUrl { get; set; }
    }
}