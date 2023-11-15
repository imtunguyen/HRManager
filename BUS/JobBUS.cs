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
        public string Add(JobDTO job)
        {
            if (jobDAO.Add(job)) return "Add Job Success";
            return "Add Job fail";
        }

        public string Update(JobDTO t)
        {
            if (jobDAO.Update(t)) return " Update Job Success";
            return "Update Job Fail";
        }
        public string Delete(int id)
        {
            if (jobDAO.Delete(id)) return "Delete Job Success";
            return "Delete Fail";
        }

        public List<JobDTO> GetAll()
        {
            return jobDAO.GetAll();
        }

        public JobDTO GetById(int id)
        {
            return jobDAO.GetById(id);
        }

    }
}