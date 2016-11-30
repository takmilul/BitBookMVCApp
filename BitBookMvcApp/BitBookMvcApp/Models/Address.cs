using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVCApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentCountry { get; set; }
        public string FromCity { get; set; }
        public string FromCountry { get; set; }
        public int UserId { get; set; }
    }
}