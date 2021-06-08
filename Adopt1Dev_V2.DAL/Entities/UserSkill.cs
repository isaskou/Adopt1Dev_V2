namespace Adopt1Dev_V2.DAL.Entities
{
    public class UserSkill
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }
        public int score { get; set; }

        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }
    }
}