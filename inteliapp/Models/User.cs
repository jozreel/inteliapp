﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inteliapp.Models
{
    public class User
    {
        public User()
        {
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int userID { get; set; }
    }
}