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
        public bool UpdateBasePay(int Id, double basePay)
        {
            if(edao.UpdateBasePay(Id, basePay))
            {
                return true;
            }
            return false;
        }
        public bool UpdateDayJoin(int Id, DateTime dayJoin)
        {
            if(edao.UpdateDayJoin(Id,dayJoin))
            {
                return true;
            }
            return false;
        }
    }

}
