﻿using EgzamenDaw.Models.Enums;
using EgzamenDaw.Models.Base;

namespace EgzamenDaw.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
