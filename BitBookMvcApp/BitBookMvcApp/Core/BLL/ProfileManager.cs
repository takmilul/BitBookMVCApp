﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookMVCApp.Core.DAL;
using BitBookMVCApp.Models;

namespace BitBookMVCApp.Core.BLL
{
    public class ProfileManager
    {
        ProfileGateway _profileGateway = new ProfileGateway();
        public Profile GetProfileByUserId(int userId)
        {
            return _profileGateway.GetProfileByUserId(userId);
        }

        public int UpdateName(int userId, string firstName, string lastName)
        {
            return _profileGateway.UpdateName(userId, firstName, lastName);
        }

        public int UpdateProPicId(int userId, int proPicId)
        {
            return _profileGateway.UpdateProPicId(userId, proPicId);
        }

        public int UpdateCoverPicId(int userId, int coverPicId)
        {
            return _profileGateway.UpdateCoverPicId(userId, coverPicId);
        }

        public int UpdateReligion(int userId, string religion)
        {
            return _profileGateway.UpdateReligion(userId, religion);
        }

        public int UpdateRelationship(int userId, bool hasRelationship, string relationship, int relationshipWithId)
        {
            return _profileGateway.UpdateRelationship(userId, hasRelationship, relationship, relationshipWithId);
        }

        public int UpdateAbout(int userId, string about)
        {
            return _profileGateway.UpdateAbout(userId, about);
        }
    }
}