using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class ContractDAO : InterfaceDAO<Contract>
	{
		public static ContractDAO GetInstance() { return new ContractDAO(); }
		public bool Add(Contract t)
		{
			try
			{
				using (SqlConnection conn = DbConnection.GetSqlConnection())
				{
					string query = "insert into Contract (name, employee_id, fromDate, toDate, status, job_id, department_id, hr_id, detail, requiredDay)" +
						" values (@name, @employee_id, @fromDate, @toDate, @status, @job_id, @department_id, @hr_id, @detail, @requiredDay)";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@name", t.Name);
						cmd.Parameters.AddWithValue("@employee_id", t.EmployeeId);
						cmd.Parameters.AddWithValue("@fromDate", t.FormDate);
						cmd.Parameters.AddWithValue("@toDate", t.ToDate);
						cmd.Parameters.AddWithValue("@status", t.Status);
						cmd.Parameters.AddWithValue("@job_id", t.JobId);
						cmd.Parameters.AddWithValue("@department_id", t.DepartmentId);
						cmd.Parameters.AddWithValue("@hr_id", t.HrId);
						cmd.Parameters.AddWithValue("@detail", t.Detail);
						cmd.Parameters.AddWithValue("@requiredDay", t.RequiredDay);
						int rowsChanged = cmd.ExecuteNonQuery();
						return rowsChanged > 0;
					}
				}
			}
			catch (Exception ex)
			{
				ex.ToString();
				return false;
			}

		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contract> GetAll()
		{
			List<Contract> List = new List<Contract>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM CONTRACT";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Contract contract = new Contract
							{
								Id = Convert.ToInt32(reader["id"]),
								Name = reader["name"].ToString(),
								EmployeeId = Convert.ToInt32(reader["employee_id"]),
								FormDate = Convert.ToDateTime(reader["fromDate"]),
								ToDate = Convert.ToDateTime(reader["toDate"]),
								DepartmentId = Convert.ToInt32(reader["department_id"]),
								HrId = Convert.ToInt32(reader["hr_id"]),
								Detail = reader["detail"].ToString(),
								RequiredDay = Convert.ToInt32(reader["requiredDay"]),
								Status = reader["status"].ToString(),
							};
							List.Add(contract);
						}
					}
				}
			}
			return List;
		}

		public Contract GetById(int id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Contract t)
		{
			throw new NotImplementedException();
		}
	}
}
