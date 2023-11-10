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
        EmployeeDAO edao;
        public EmployeeBUS() {
            edao = EmployeeDAO.getInstance();
        }
        public List<EmployeeDTO> GetAll()
        {
            return edao.GetAll();
        }
    }

}
