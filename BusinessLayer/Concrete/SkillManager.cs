using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skill;

        public SkillManager(ISkillDal skill)
        {
            _skill = skill;
        }

        public List<Skill> GetList()
        {
            return _skill.List();
        }
    }
}
