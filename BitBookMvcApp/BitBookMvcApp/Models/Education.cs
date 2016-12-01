using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Institute { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool HasDegree { get; set; }
        public string Degree { get; set; }
        public int UserId { get; set; }

    }
}