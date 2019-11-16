﻿using System;
namespace NUnitProject.Model.Objects
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
