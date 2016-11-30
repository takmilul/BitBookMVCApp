using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookMVCApp.Core.DAL;
using BitBookMVCApp.Models;

namespace BitBookMVCApp.Core.BLL
{
    public class UserManager
    {
        UserGateway _userGateway = new UserGateway();
        public User GetUserByProfileId(int proifleId)
        {
            return _userGateway.GetListofUserByProfileId(proifleId);
        }

        public User GetUserByEmail(string email)
        {
            return _userGateway.GetUserByEmail(email);
        }

        public bool IsEmailExitst(string email)
        {

            if (GetUserByEmail(email) != null)
            {
                return true;
            }

            return false;
        }
    }
}