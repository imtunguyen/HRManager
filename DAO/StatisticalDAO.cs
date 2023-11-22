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
	}

}
