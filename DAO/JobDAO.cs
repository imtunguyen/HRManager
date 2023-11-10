using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class JobDAO : InterfaceDAO<Job>
	{
		public static JobDAO GetInstance()
		{
			return new JobDAO();
		}
		public bool Add(Job t)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Job> GetAll()
		{
			List<Job> jobs = new List<Job>();
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select * from Job";
				using(SqlCommand cmd = new SqlCommand(query, conn))
				{
					using(SqlDataReader reader = cmd.ExecuteReader())
					{
						while(reader.Read())
						{
							Job j = new Job
							{
								ID = Convert.ToInt32(reader["id"]),
								Job_Name = reader["job_name"].ToString(),
								Role = reader["role"].ToString(),
								Description = reader["description"].ToString(),
							};
							jobs.Add(j);
						}
					}
				}
			}
			return jobs;
		}

		public Job GetById(int id)
		{
			throw new NotImplementedException();
		}

		public bool Update(Job t)
		{
			throw new NotImplementedException();
		}
	}
}
