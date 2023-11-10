using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class JobBUS
    {
        private JobDAO jobDAO;
        public JobBUS()
        {
            jobDAO = JobDAO.GetInstance();
        }

        public List<Job> GetAll()
        {
            return jobDAO.GetAll();
        } 
    }
}
