using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ContractBUS
	{
		private ContractDAO contractDAO;
		public ContractBUS()
		{
			contractDAO = ContractDAO.GetInstance();
		}

		public List<Contract> GetAll()
		{
			return contractDAO.GetAll();
		}

		public bool Add(Contract t)
		{
			if(contractDAO.Add(t))
			{
				return true;
			}
			return false;
		}

		public bool Update(Contract t)
		{
			if(contractDAO.Update(t))
			{
				return true;
			}
			return false;
		}
		public Contract GetById(int id)
		{
			return contractDAO.GetById(id);
		}
		public List<Contract> GetByEmployeeId(int employeeId)
		{
			return contractDAO.GetByEmployeeId(employeeId);
		}
	}
}
