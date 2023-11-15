using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class JobDAO : InterfaceDAO<JobDTO>
    {
        public static JobDAO getInstance() 
        {
            return new JobDAO();
        }
        public bool Add(JobDTO t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO JOB (job_name,role, description)" +
                        "VALLUE (@job_name, @role, @description)";
                    using (SqlCommand comand=new SqlCommand(query, connection))
                    {
                        comand.Parameters.AddWithValue("@job_name", t.Job_Name);
                        comand.Parameters.AddWithValue("@role", t.role);
                        comand.Parameters.AddWithValue("@description", t.description);
                        int rowsChanged = comand.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                var command = new SqlCommand("DELETE FROM JOB WHERE id = @id", DbConnection.GetSqlConnection());
                command.Parameters.AddWithValue("@id", id);
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
           
        }

        public List<JobDTO> GetAll()
        {
            List<JobDTO> joblist = new List<JobDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM JOB";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            JobDTO job = new JobDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Job_Name = reader["job_name"].ToString(),
                                role = reader["role"].ToString(),
                                description = reader["description"].ToString()
                            };
                            joblist.Add(job);
                        }
                    }
                }
            }
            return joblist;
        }

        public JobDTO GetById(int id)
        {
            JobDTO result = null;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM JOB WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = new JobDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Job_Name = reader["job_name"].ToString(),
                                role = reader["role"].ToString(),
                                description = reader["description"].ToString()
                            };
                        }
                    }
                }
            }
            return result;
        }

        public bool Update(JobDTO t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update JOB set job_name = @job_name, role = @role, description = @description where id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", t.ID);
                        command.Parameters.AddWithValue("@name", t.Job_Name);
                        command.Parameters.AddWithValue("@location_id", t.role);
                        command.Parameters.AddWithValue("@address_detail", t.description);
                        int rowsChanged = command.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
