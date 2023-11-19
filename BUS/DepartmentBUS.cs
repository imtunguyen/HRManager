using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DepartmentBUS
    {
        private DepartmentDAO departmentDAO;
        public DepartmentBUS()
        {
            departmentDAO = DepartmentDAO.GetInstance();
        }
        public List<Department> GetAll()
        {
            return departmentDAO.GetAll();
        }
        public Department GetById(int id)
        {
            return departmentDAO.GetById(id);
        }
    }
}
