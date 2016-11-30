using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMVCApp.Models
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public int FamilyMemberId { get; set; }
        public string Relationship { get; set; }
        public int UserId { get; set; }
    }
}