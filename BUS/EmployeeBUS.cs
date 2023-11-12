using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        public EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public List<Employee> getAll()
        {
            return employeeDAO.GetAll();
        }

        public DTO.Employee getById(int id)
        {
            return employeeDAO.GetById(id);
        }
    }
}
