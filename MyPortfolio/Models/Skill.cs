using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }

        virtual public ICollection<SkillDetails> SkillDetails { get; set; }
    }
}
