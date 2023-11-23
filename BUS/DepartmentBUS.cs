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
        public DepartmentDAO departmentDAO;
        public DepartmentBUS()
        {
            departmentDAO = DepartmentDAO.getInstance();
        }
        public bool Add(Department t)
        {
            return departmentDAO.Add(t);
        }
        public bool Update(int id, Department t)
        {
            return departmentDAO.Update(id, t);
        }
        public string Delete(int id)
        {
            if (departmentDAO.Delete(id)) return "Delete Department Success";
            return "Delete Fail";
        }
        public int CountEmployee(int id)
        {
            return departmentDAO.CountEmployee(id);
        }
        public List<Department> GetAll()
        {
            return departmentDAO.GetAll();
        }
        public List<Department> GetAll(int DeID)
        {
            return departmentDAO.GetAll(DeID);
        }
        public List<Department> GetID()
        {
            return departmentDAO.GetID();
        }
        public int GetAutoIncrement()
        {
            return DepartmentDAO.getInstance().GetAutoIncrement();
        }
        public Department getById(int id)
        {
            return departmentDAO.GetById(id);
        }
    }
}