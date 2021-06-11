using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dev_V2.ASP.Models
{
    public class SkillModel
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        public virtual SkillCategoryModel SkillCategory { get; set; }
        public virtual IEnumerable<UserSkillModel> UserSkills { get; set; }

    }
}
