using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class ProfessionalSkills
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int UserId { get; set; }
    }
}