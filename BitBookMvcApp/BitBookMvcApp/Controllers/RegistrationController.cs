using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitBookMVCApp.Core.BLL;
using BitBookMVCApp.Models;
using BitBookMVCApp.ViewModels;
using BitBookMVCApp.ViewModels.Registration;

namespace BitBookMVCApp.Controllers
{
    public class RegistrationController : Controller
    {
        RegistrationManager _registrationManager = new RegistrationManager();

        public ActionResult SaveUser()
        {
            ViewBag.Days = DaysDropDown();
            ViewBag.Months = MonthDropDown();
            ViewBag.Years = YearList();
            return View();
        }

        [HttpPost]
        public ActionResult SaveUser(RegistrationAndLogin registrationAndLogin, string day, string month, string year)
        {
            var dateOfBirth = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            registrationAndLogin.Registration.DateOfBirth = dateOfBirth;
            int rowsAffected = 0;
            try
            {
                rowsAffected = _registrationManager.SaveUser(registrationAndLogin.Registration);
                if (rowsAffected > 0)
                {
                    ViewBag.Message = "Saved successfully";
                }
                else
                {
                    ViewBag.Message = "Save failed";
                }
            }
            catch (Exception exception)
            {
                ViewBag.Message = exception.Message;
            }

            ViewBag.Days = DaysDropDown();
            ViewBag.Months = MonthDropDown();
            ViewBag.Years = YearList();

            return View();
        }

        public List<SelectListItem> DaysDropDown()
        {
            var days = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Days", Value = ""}
            };

            for (int i = 1; i <= 31; i++)
            {
                var day = new SelectListItem() { Text = Convert.ToString(i), Value = Convert.ToString(i) };
                days.Add(day);
            }
            return days;
        }

        public List<SelectListItem> MonthDropDown()
        {
            var monthList = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Month", Value = ""}
            };
            var monthArray = new string[]
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };

            for (int i = 1; i <= 12; i++)
            {
                var month = new SelectListItem() { Text = monthArray[i - 1], Value = Convert.ToString(i) };
                monthList.Add(month);
            }
            return monthList;
        }

        public List<SelectListItem> YearList()
        {
            var yearList = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Year", Value = ""}
            };


            for (int i = 1900; i <= DateTime.Today.Year; i++)
            {
                var year = new SelectListItem() { Text = Convert.ToString(i), Value = Convert.ToString(i) };
                yearList.Add(year);
            }
            return yearList;
        }
    }
}