using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PaySlipBUS
    {
        PaySlipDAO paySlipDAO;
        public PaySlipBUS()
        {
            paySlipDAO = new PaySlipDAO();
        }
        public List<PaySlipDTO> getAll()
        {
            return paySlipDAO.GetAll();
        }

        public string Add(PaySlipDTO paySlipDTO)
        {
            if(paySlipDAO.Add(paySlipDTO))
            {
                return "thêm thành công!";
            }
            else
            {
                return "thêm thất bại!";
            }
        }

        public PaySlipDTO GetById(int id)
        {
            return paySlipDAO.GetById(id);
        }

        public List<PaySlipDTO> SearchByEmployeeName(string name)
        {
            return paySlipDAO.SearchByName(name);
        }
        public List<PaySlipDTO> Search(string name, string status)
        {
            return paySlipDAO.Search(name.Trim(), status.Trim());
        }
        public List<PaySlipDTO> SearchByStatus(string status)
        {
            return paySlipDAO.SearchByStatus(status.Trim());
        }

        public bool Update(string status, int id)
        {
            return paySlipDAO.Update(status, id);
        }
    }
}
