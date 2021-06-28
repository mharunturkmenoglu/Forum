using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public string SkillAbout { get; set; }

        [StringLength(50)]
        public string Skill1 { get; set; }

        [StringLength(50)]
        public string Skill2 { get; set; }

        [StringLength(50)]
        public string Skill3 { get; set; }

        [StringLength(50)]
        public string Skill4 { get; set; }

        [StringLength(50)]
        public string Skill5 { get; set; }

        [StringLength(50)]
        public string Skill6 { get; set; }

        [StringLength(50)]
        public string Skill7 { get; set; }

        public int SkillValue1 { get; set; }
        public int SkillValue2 { get; set; }
        public int SkillValue3 { get; set; }
        public int SkillValue4 { get; set; }
        public int SkillValue5 { get; set; }
        public int SkillValue6 { get; set; }
        public int SkillValue7 { get; set; }
    }
}
