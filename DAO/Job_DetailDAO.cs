using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Job_DetailDAO : InterfaceDAO<Job_Detail>
    {
		public bool Add(Job_Detail jobDetail)
		{
			try
			{
				using (SqlConnection conn = DbConnection.GetSqlConnection())
				{
					SqlCommand cmd = new SqlCommand("INSERT INTO JOB_DETAIL (employee_id, department_id, job_id, fromDate, description, status) VALUES (@employee_id, @department_id, @job_id, @fromDate, @description, @status)", conn);

					cmd.Parameters.AddWithValue("@employee_id", jobDetail.EmployeeID);
					cmd.Parameters.AddWithValue("@department_id", jobDetail.DepartmentID);
					cmd.Parameters.AddWithValue("@job_id", jobDetail.JobID);
					cmd.Parameters.AddWithValue("@fromDate", jobDetail.FromDate);
					cmd.Parameters.AddWithValue("@description", jobDetail.Description);
					cmd.Parameters.AddWithValue("@status", jobDetail.Status);

					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
			} catch(Exception ex)
			{
				ex.ToString();
				return false;
			}
			
		}

		public bool Update(Job_Detail jobDetail)
		{
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				SqlCommand cmd = new SqlCommand("UPDATE JOB_DETAIL SET employee_id = @employee_id, department_id = @department_id, job_id = @job_id, fromDate = @fromDate, toDate = @toDate, description = @description, status = @status WHERE id = @id", conn);

				cmd.Parameters.AddWithValue("@id", jobDetail.ID);
				cmd.Parameters.AddWithValue("@employee_id", jobDetail.EmployeeID);
				cmd.Parameters.AddWithValue("@department_id", jobDetail.DepartmentID);
				cmd.Parameters.AddWithValue("@job_id", jobDetail.JobID);
				cmd.Parameters.AddWithValue("@fromDate", jobDetail.FromDate);
				cmd.Parameters.AddWithValue("@toDate", jobDetail.ToDate);
				cmd.Parameters.AddWithValue("@description", jobDetail.Description);
				cmd.Parameters.AddWithValue("@status", jobDetail.Status);

				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public bool Delete(int id)
		{
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				SqlCommand cmd = new SqlCommand("DELETE FROM JOB_DETAIL WHERE id = @id", conn);
				cmd.Parameters.AddWithValue("@id", id);

				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}

		public List<Job_Detail> GetAll()
		{
			List<Job_Detail> jobDetails = new List<Job_Detail>();

			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				SqlCommand cmd = new SqlCommand("SELECT * FROM JOB_DETAIL", conn);

				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Job_Detail jobDetail = new Job_Detail();
					jobDetail.ID = (int)reader["id"];
					jobDetail.EmployeeID = (int)reader["employee_id"];
					jobDetail.DepartmentID = (int)reader["department_id"];
					jobDetail.JobID = (int)reader["job_id"];
					jobDetail.FromDate = Convert.ToDateTime(reader["fromDate"]);

					DateTime dateLeft;
					jobDetail.ToDate = DateTime.TryParse(reader["toDate"].ToString(), out dateLeft) ? dateLeft : null;

					// Thay thế bằng
					if (DateTime.TryParse(reader["toDate"].ToString(), out dateLeft))
					{
						jobDetail.ToDate = dateLeft;
					}
					else
					{
						jobDetail.ToDate = null;
					}
					jobDetail.Description = (string)reader["description"];
					jobDetail.Status = (string)reader["status"];

					jobDetails.Add(jobDetail);
				}

				return jobDetails;
			}
		}

		public Job_Detail GetById(int id)
		{
			Job_Detail jobDetail = null;

			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				SqlCommand cmd = new SqlCommand("SELECT * FROM JOB_DETAIL WHERE id = @id", conn);
				cmd.Parameters.AddWithValue("@id", id);

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					jobDetail = new Job_Detail();
					jobDetail.ID = (int)reader["id"];
					jobDetail.EmployeeID = (int)reader["employee_id"];
					jobDetail.DepartmentID = (int)reader["department_id"];
					jobDetail.JobID = (int)reader["job_id"];
					jobDetail.FromDate =Convert.ToDateTime(reader["fromDate"]);
					DateTime dateLeft;
					jobDetail.ToDate = DateTime.TryParse(reader["toDate"].ToString(), out dateLeft) ? dateLeft : null;

					// Thay thế bằng
					if (DateTime.TryParse(reader["toDate"].ToString(), out dateLeft))
					{
						jobDetail.ToDate = dateLeft;
					}
					else
					{
						jobDetail.ToDate = null;
					}
					jobDetail.Description = (string)reader["description"];
					jobDetail.Status = (string)reader["status"];
				}

				return jobDetail;
			}
		}
	}
}
