using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class StatisticalBUS
	{
		StatisticalDAO statisticalDAO;
		public StatisticalBUS()
		{
			statisticalDAO = StatisticalDAO.GetInstance();
		}
		public int GetCountDepartment() { return statisticalDAO.GetCountDepartment(); }
		public int GetCountContract() { return statisticalDAO.GetCountContract(); }
		public int GetCountActiveEmployee() { return statisticalDAO.GetCountActiveEmployee(); }

		public List<EmployeeDTO> GetInfoSalaryEmployee(DateTime fromDate, DateTime toDate) { return statisticalDAO.GetInfoSalaryEmployee(fromDate, toDate); }

	}
}
