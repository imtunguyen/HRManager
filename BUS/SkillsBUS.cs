using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class SkillsBUS
    {
        private SkillsDAO skillsDAO;

        public SkillsBUS()
        {
            this.skillsDAO = new SkillsDAO();
        }

        public bool AddSkill(Skills skill)
        {
            return skillsDAO.Add(skill);
        }
        public bool UpdateSkill(Skills skill)
        {
            return skillsDAO.Update(skill);
        }
        public bool DeleteSkill(int id)
        {
            return skillsDAO.Delete(id);
        }
        public List<Skills> GetAllSkills()
        {
            return skillsDAO.GetAll();
        }
        public Skills GetSkillById(int id)
        {
            return skillsDAO.GetById(id);
        }
        public int GetMaxSkillId()
        {
            return skillsDAO.GetMaxSkillId();
        }



    }
}
