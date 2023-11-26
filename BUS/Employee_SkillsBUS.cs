using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class Employee_SkillsBUS
    {
        DAO.Employee_Skills edao;
        public Employee_SkillsBUS()
        {
            edao = DAO.Employee_Skills.getInstance();
        }
        public bool Add(DTO.Employee_Skills dto)
        {
            return edao.Add(dto);
        }
        public bool Update(int id, DTO.Employee_Skills dto)
        {
            return edao.Update(id, dto);
        }
        public List<DTO.Employee_Skills> GetAll()
        {
            return edao.GetAll();
        }
        public List<DTO.Employee_Skills> GetByEmployeeId(int id)
        {
            return edao.GetByEmployeeId(id);
        }
        public DTO.Employee_Skills GetById(int id)
        {
            return edao.GetById(id);
        }
        public bool Delete(int id)
        {
            return edao.Delete(id);
        }
        public List<DTO.Employee_Skills> GetEmployeeID()
        {
            return edao.GetEmployee_ID();
        }
    }
}
