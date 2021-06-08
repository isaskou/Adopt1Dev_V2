namespace Adopt1Dev_V2.DAL.Entities
{
    public class UserSalary
    {
        public int ProfileId { get; set; }
        public int SalaryId { get; set; }

        public double Montant { get; set; }

        public User User { get; set; }
        public Salary Salary { get; set; }

    }
}