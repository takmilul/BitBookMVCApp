﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookMvcApp.ViewModels.Registration;

namespace BitBookMvcApp.ViewModels.Registration
{
    public class RegistrationAndLogin
    {
        public BitBookMvcApp.ViewModels.Registration.Registration Registration { get; set; }
        public Login Login { get; set; }
    }
}