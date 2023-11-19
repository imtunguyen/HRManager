using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Job_DetailBUS
    {
		private Job_DetailDAO jobDetailDAO = new Job_DetailDAO();

		public bool Add(Job_Detail jobDetail)
		{
			if(jobDetailDAO.Add(jobDetail)) return true;
			return false;
		}

		public bool Update(Job_Detail jobDetail)
		{
			return jobDetailDAO.Update(jobDetail);
		}

		public bool Delete(int id)
		{
			return jobDetailDAO.Delete(id);
		}

		public List<Job_Detail> GetAll()
		{
			return jobDetailDAO.GetAll();
		}

		public Job_Detail GetById(int id)
		{
			return jobDetailDAO.GetById(id);
		}
	}
}
