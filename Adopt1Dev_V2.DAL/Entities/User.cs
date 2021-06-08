﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dev_V2.DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }
        public byte[] Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public byte[] ImageFile { get; set; }
        public string ImageMimeType { get; set; }

        public IEnumerable<UserSalary> UserSalaries { get; set; }
        public IEnumerable<UserSkill> UserSkills { get; set; }
    }
}
