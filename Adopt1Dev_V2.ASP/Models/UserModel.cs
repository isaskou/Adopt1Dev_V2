using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Adopt1Dev_V2.Tools;

namespace Adopt1Dev_V2.ASP.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public byte[] PasswordOut
        {
            get
            {
                return Security.HashMe(PasswordIn);
            }
        }

        public string PasswordIn { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public byte[] ImageFile { get; set; }
        public string ImageMimeType { get; set; }

        public IEnumerable<UserSalaryModel> UserSalaries { get; set; }
        public IEnumerable<UserSkillModel> UserSkills { get; set; }

    }
}
