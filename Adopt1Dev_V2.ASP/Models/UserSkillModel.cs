using Adopt1Dev_V2.DAL.Entities;

namespace Adopt1Dev_V2.ASP.Models
{
    public class UserSkillModel
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }
        public int score { get; set; }

        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }

    }
}