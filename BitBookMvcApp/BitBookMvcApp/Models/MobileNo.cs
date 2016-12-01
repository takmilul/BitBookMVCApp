using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class MobileNo
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public int UserId { get; set; }
    }
}