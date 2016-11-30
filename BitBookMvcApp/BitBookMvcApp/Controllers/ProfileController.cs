﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBookMVCApp.Core.BLL;
using BitBookMVCApp.Models;
namespace BitBookMVCApp.Controllers
{
    public class ProfileController : Controller
    {
        ProfileManager _profileManager = new ProfileManager();
        public ActionResult About()
        {
            ViewBag.Relationship = GetAllRelationship();

            int userId = (int)Session["UserId"];
            Profile profile = _profileManager.GetProfileByUserId(userId);
            ViewBag.Profile = profile;
            return View();
        }

        private List<Relationship> GetAllRelationship()
        {
            return new List<Relationship>
            {
                new Relationship{Id = 0, RelationshipName = "Single"},
                new Relationship{Id = 1, RelationshipName = "In a relationship"},
                new Relationship{Id = 2, RelationshipName = "In an open relationship"},
                new Relationship{Id = 3, RelationshipName = "It's complicated"},
            };
        }
    }
}