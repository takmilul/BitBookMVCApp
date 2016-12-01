using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string FullName { get; set; }
        public string ProPicUrl { get; set; }
        public bool IsAccepted { get; set; }
    }
}