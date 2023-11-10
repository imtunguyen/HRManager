using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WorkEntryBUS
    {
        public WorkEntryDAO workEntryDAO;

        public WorkEntryBUS()
        {
            workEntryDAO = new WorkEntryDAO();
        }

        public bool IsEmployeeDone(string date, int id)
        {
            return workEntryDAO.IsEmployeeDone(date, id);
        }
        public bool IsEmployeeExistInDatabase(string date, int id)
        {
            return workEntryDAO.IsEmployeeExistInDatabase(date, id);
        }
        public bool Add(WorkEntry workEntry)
        {
            return workEntryDAO.Add(workEntry);
        }
        public bool Update(WorkEntry workEntry)
        {
            return workEntryDAO.Update(workEntry);
        }
    }
}
