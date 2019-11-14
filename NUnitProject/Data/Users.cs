using System;
using NUnitProject.Model.Objects;

namespace NUnitProject.Data
{
    public static class Users
    {
        public static User ValidUser = new User("test@test.com", "password");
        public static User InvalidUser = new User("invalid@invalid.com", "password");
        public static User IncorrectPasswordUser = new User("test@test.com", "incorrect");
    }
}
