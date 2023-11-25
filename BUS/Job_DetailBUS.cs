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
    public class Job_DetailBUS
    {
		private Job_DetailDAO jobDetailDAO;
		public Job_DetailBUS()
		{
			jobDetailDAO = Job_DetailDAO.GetInstance();
		}

		public bool Add(Job_Detail jobDetail)
		{
			return jobDetailDAO.Add(jobDetail);
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
		public int CheckDateOverLap(int id, DateTime fromDate, DateTime toDate)
		{
			return jobDetailDAO.checkDateOverLap(id, fromDate, toDate);
		}
	}
}
