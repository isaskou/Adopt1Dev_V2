using Adopt1Dev_V2.DAL.Entities;

namespace Adopt1Dev_V2.ASP.Models
{
    public class UserSalaryModel
    {
        public int UserId { get; set; }
        public int SalaryId { get; set; }

        public double Montant { get; set; }

        public User User { get; set; }
        public Salary Salary { get; set; }

    }
}