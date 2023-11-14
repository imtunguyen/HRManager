using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BonusAndFinesBUS
    {
        BonusAndFinesDAO bonusAndFinesDAO;
        public BonusAndFinesBUS()
        {
            bonusAndFinesDAO = new BonusAndFinesDAO();
        }
        public List<BonusAndFines> GetAll()
        {
            return bonusAndFinesDAO.GetAll();
        }

        public string Add(DTO.BonusAndFines bonusAndFines)
        {
            if(bonusAndFinesDAO.Add(bonusAndFines))
            {
                return "thêm thành công!";
            }
            else
            {
                return "thêm thất bại!";
            }
        }

        public Decimal getAllBonusOfEmployee(int employeeID, string date) 
        {
            return bonusAndFinesDAO.getAllBonusOfEmployee(employeeID, date);
        }

        public Decimal getAllFinesOfEmployee(int employeeID, string date)
        {
            return bonusAndFinesDAO.getAllFinesOfEmployee(employeeID, date);
        }

        public List<BonusAndFines> Search(string type, string name)
        {
            return bonusAndFinesDAO.Search(type.Trim(), name.Trim());
        }

        public List<BonusAndFines> SearchByEmployeeName(string name)
        {
            return bonusAndFinesDAO.SearchByEmployeeName(name.Trim());
        }

        public List<BonusAndFines> SearchByType(string type)
        {
            return bonusAndFinesDAO.SearchByType(type.Trim());
        }

        public DTO.BonusAndFines getById(int id)
        {
            return bonusAndFinesDAO.GetById(id);
        }

        public string Delete(int id)
        {
            if (bonusAndFinesDAO.Delete(id))
            {
                return "xóa thành công";
            }
            else
            {
                return "xóa thất bại";
            }
        }

        public string Update(BonusAndFines t)
        {
            if (bonusAndFinesDAO.Update(t))
            {
                return "update thành công";
            }
            else
            {
                return "update thất bại";
            }
        }
    }
}