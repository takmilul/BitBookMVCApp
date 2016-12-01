using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int ProPicId { get; set; }
        public int CoverPicId { get; set; }
        public string Religion { get; set; }
        public bool HasRelationship { get; set; }
        public string Relationship { get; set; }
        public int RelationshipWithId { get; set; }
        public string About { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }


        public int RelationshipId { get; set; }

        public Profile()
        {

        }

        public Profile(int id, string firstName, string lastName, string fullName, DateTime dateOfBirth, string gender, int proPicId, int coverPicId, string religion, bool hasRelationship, string relationship, int relationshipWithId, string about, DateTime createDate, int userId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            ProPicId = proPicId;
            CoverPicId = coverPicId;
            Religion = religion;
            HasRelationship = hasRelationship;
            Relationship = relationship;
            RelationshipWithId = relationshipWithId;
            About = about;
            CreateDate = createDate;
            UserId = userId;
        }
    }
}