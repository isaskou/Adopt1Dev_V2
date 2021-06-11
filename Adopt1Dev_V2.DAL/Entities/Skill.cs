
using System.Collections.Generic;

namespace Adopt1Dev_V2.DAL.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        public virtual SkillCategory SkillCategory { get; set; }
        public virtual IEnumerable<UserSkill> UserSkills { get; set; }

    }
}