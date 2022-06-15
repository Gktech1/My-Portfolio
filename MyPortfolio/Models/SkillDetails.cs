using System;

namespace MyPortfolio.Models
{
    public class SkillDetails
    { 
        public Guid SkillDetailsId { get; set; }

        public string Name { get; set; }
        public string Percentage { get; set; }


        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
