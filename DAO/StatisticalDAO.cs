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
				string query = "SELECT e.id, e.name AS employee_name, c.requiredDay, c.basePay," +
					"\r\nISNULL(bf.total_bonus, 0) as total_bonus, ISNULL(bf.total_fines, 0) " +
					"as total_fines,\r\nISNULL(SUM(p.total),0) as total_salary\r\n" +
					"FROM EMPLOYEE e JOIN CONTRACT c ON e.id = c.employee_id\r\n" +
					"LEFT JOIN (SELECT b.employee_id, SUM(CASE WHEN b.type = 'bonus' " +
					"THEN b.amount ELSE 0 END) as total_bonus,\r\n        " +
					"SUM(CASE WHEN b.type = 'fines' THEN b.amount ELSE 0 END) " +
					"as total_fines FROM BONUS_AND_FINES b WHERE " +
					$"b.expired_date >= '{fromDate}' AND b.expired_date <= '{toDate}'\r\n" +
					"GROUP BY b.employee_id) bf ON bf.employee_id = e.id" +
					"\r\nLEFT JOIN PAYSLIP p ON p.contract_id = c.id " +
					$"AND p.from_date <= '{toDate}' AND p.to_date >= '{fromDate}'\r\nWHERE\r\n  " +
					"  c.status = 'Running'\r\nGROUP BY\r\n   " +
					" e.id, e.name, c.requiredDay, c.basePay, bf.total_bonus, bf.total_fines;";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int id_e = Convert.ToInt32(reader["id"]);
							string employee_name = (string)reader["employee_name"];
							int rqday = Convert.ToInt32(reader["requiredDay"]);
							decimal basepay = Convert.ToDecimal(reader["basePay"]);
							decimal bonus = Convert.ToDecimal(reader["total_bonus"]);
							decimal fines = Convert.ToDecimal(reader["total_fines"]);
							decimal salary = Convert.ToDecimal(reader["total_salary"]);
							EmployeeDTO e = new EmployeeDTO(id_e, employee_name, rqday, basepay, bonus, fines, salary);
							list.Add(e);
						}
					}
				}
			}
			return list;
		}

		public List<EmployeeDTO> Top5Employee(DateTime fromDate, DateTime toDate)
		{
			List<EmployeeDTO> list = new List<EmployeeDTO>();
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = $"select top 5 e.id, e.name as employee_name, j.job_name, d.name,sum(p.total) as total from PAYSLIP p join EMPLOYEE e \r\non e.id = p.employee_id join JOB_DETAILS jd on jd.employee_id = e.id\r\njoin JOB j on j.id = jd.job_id join DEPARTMENT d on d.id = jd.department_id\r\nwhere p.from_date >= '{fromDate}' AND p.to_date <= '{toDate}'\r\ngroup by e.id, e.name, j.job_name, d.name";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int id_e = Convert.ToInt32(reader["id"]);
							string employee_name = (string)reader["employee_name"];
							string job = (string)reader["job_name"];
							string department = (string)reader["name"];
							decimal salary = Convert.ToDecimal(reader["total"]);
							EmployeeDTO e = new EmployeeDTO(id_e, employee_name, job, department, salary);
							list.Add(e);
						}
					}
				}
			}
			return list;
		}
	}

}
