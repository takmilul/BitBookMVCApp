using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookMVCApp.Core.DAL;
using BitBookMVCApp.Models;
using BitBookMVCApp.ViewModels;
using BitBookMVCApp.ViewModels.Registration;

namespace BitBookMVCApp.Core.BLL
{
    public class RegistrationManager
    {
        UserManager _userManager = new UserManager();
        ProfileManager _profileManager = new ProfileManager();
        public int SaveUser(Registration userInput)
        {
            User user = new User { Email = userInput.Email, Password = userInput.Password };

            bool isUserExist = _userManager.GetUserByEmail(user.Email) != null;
            if (isUserExist)
            {
                throw new Exception("Email already exist");
            }
            int userRowsAffected = _userManager.InsertUser(user);
            int userId = _userManager.GetUserByEmail(user.Email).Id;
            Profile profile = new Profile { FirstName = userInput.FirstName, LastName = userInput.LastName, DateOfBirth = userInput.DateOfBirth, Gender = userInput.Gender, UserId = userId, CreateDate = DateTime.Today };
            int profileRowsAffected = _profileManager.InsertProfile(profile);

            if (userRowsAffected < 1 || profileRowsAffected < 1)
            {
                return 0;
            }
            return 1;
        }
    }
}