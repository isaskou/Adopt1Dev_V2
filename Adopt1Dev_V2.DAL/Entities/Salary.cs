using System.Collections.Generic;

namespace Adopt1Dev_V2.DAL.Entities
{
    public class Salary
    {
        public int SalaryId { get; set; }

        public string Period { get; set; }

        public IEnumerable<UserSalary> UserSalaries { get; set; }

    }
}