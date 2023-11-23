using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class StatisticalDAO
	{
		public static StatisticalDAO GetInstance()
		{
			return new StatisticalDAO();
		}

		public int GetCountDepartment()
		{
			int count = 0;
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select count(*) from Department";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					count = (int)cmd.ExecuteScalar();
				}
			}
			return count;
		}

		public int GetCountContract()
		{
			int count = 0;
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select count(*) from Contract";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					count = (int)cmd.ExecuteScalar();
				}
			}
			return count;
		}

		public int GetCountActiveEmployee()
		{
			int count = 0;
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select count(*) from EMPLOYEE e join CONTRACT c on e.id = c.employee_id where c.status = 'Running'";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					count = (int)cmd.ExecuteScalar();
				}
			}
			return count;
		}

		public List<EmployeeDTO> GetInfoSalaryEmployee(DateTime fromDate, DateTime toDate)
		{
			List<EmployeeDTO> list = new List<EmployeeDTO>();
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select e.id, e.name, j.job_name, d.name as department_name,c.requiredDay,c.basePay," +
					" p.total from EMPLOYEE e join CONTRACT c on e.id = c.employee_id " +
					"join JOB j on j.id = c.job_id join PAYSLIP p on p.contract_id = c.id " +
					"join DEPARTMENT d on d.id = e.department_id where c.status = 'Running' " +
					$"and p.from_date <= '{fromDate}' and toDate >= '{toDate}'";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = Convert.ToInt32(reader["id"]);
							string name = reader["name"].ToString();
							string job_name = reader["job_name"].ToString();
							string department_name = reader["department_name"].ToString();
							int required_day = Convert.ToInt32(reader["requiredDay"]);
							decimal basepay = Convert.ToDecimal(reader["basePay"]);
							decimal total = Convert.ToDecimal(reader["total"]);
							EmployeeDTO e = new EmployeeDTO(id, name, job_name, department_name, required_day, basepay, total);
							list.Add(e);
						}
					}
				}
			}
			return list;
		}
	}

}
