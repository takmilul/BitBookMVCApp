using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBookMvcApp.ViewModels.Registration
{
    public class Login
    {
        [Required(ErrorMessage = "Enter a Email Address")]
        [Display(Name = "Email")]

        public string EmailForLogin { get; set; }
        [Required(ErrorMessage = "Enter a Password")]
        [Display(Name = "Password")]
        //[Remote("UserAuthentication", "Login", ErrorMessage = "Wrong UserName or password")]
        public string PasswordForLogin { get; set; }
    }
}