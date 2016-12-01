using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string InterestedIn { get; set; }
        public int UserId { get; set; }
    }
}