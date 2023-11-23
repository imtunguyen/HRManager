using DAO;
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
		public int GetCountDepartment() { return statisticalDAO.GetCountDepartment();}
		public int GetCountContract() { return statisticalDAO.GetCountContract(); }
		public int GetCountActiveEmployee() { return statisticalDAO.GetCountActiveEmployee(); }


	}
}
