using System;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class JobBUS
    {
        private JobDAO jobDAO = new JobDAO();

        public JobBUS()
        {
            jobDAO = JobDAO.getInstance();
        }
        public bool Add(Job job)
        {
           
            return jobDAO.Add(job);
        }

        public bool Update(int id, Job job)
        {
            return jobDAO.Update(id, job);
        }
        public string Delete(int id)
        {
            if (jobDAO.Delete(id)) return "Delete Job Success";
            return "Delete Fail";
        }

        public List<Job> GetAll()
        {
            return jobDAO.GetAll();
        }

        public Job GetById(int id)
        {
            return jobDAO.GetById(id);
        }
        public int GetAutoIncrement()
        {
            return jobDAO.GetAutoIncrement();
        }
    }
}
