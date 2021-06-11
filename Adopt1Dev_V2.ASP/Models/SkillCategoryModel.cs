using System.Collections.Generic;

namespace Adopt1Dev_V2.ASP.Models
{
    public class SkillCategoryModel
    {
        public int SkillCategoryId { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<SkillModel> Skills { get; set; }

    }
}