using System.Collections.Generic;

namespace Adopt1Dev_V2.DAL.Entities
{
    public class SkillCategory
    {
        public int SkillCategoryId { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Skill> Skills { get; set; }

    }
}