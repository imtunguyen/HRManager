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
        public DepartmentBUS() {
            departmentDAO = DepartmentDAO.getInstance();
        }
        public string Add(DepartmentDTO t)
        {
            if (departmentDAO.Add(t)) return "Add Department Success";
            return "Add Department fail";
        }
        public string Update(DepartmentDTO t)
        {
            if (departmentDAO.Update(t)) return " Update Department Success";
            return "Update Department Fail";
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
        public List<DepartmentDTO> GetAll()
        {
            return departmentDAO.GetAll();
        }
        public List<DepartmentDTO> GetAll(int DeID)
        {
            return departmentDAO.GetAll(DeID);
        }
        public int GetAutoIncrement()
        {
            return DepartmentDAO.getInstance().GetAutoIncrement();
        }
        public DepartmentDTO getById(int id)
        {
            return departmentDAO.GetById(id);
        }
    }
}
