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
        public static JobDAO getInstance()
        {
            return new JobDAO();
        }
        public bool Add(Job t)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "INSERT INTO JOB (job_name, description) VALUES (@Job_Name, @Description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Job_Name", t.Job_Name);
                    command.Parameters.AddWithValue("@Description", t.Description);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            var command = new SqlCommand("DELETE FROM JOB WHERE id = @id", DbConnection.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            var result = command.ExecuteNonQuery();
            return result > 0;
        }

        public List<Job> GetAll()
        {
            List<Job> list = new List<Job>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM JOB";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Job job = new Job();
                        job.ID = Convert.ToInt32(reader["id"]);
                        job.Job_Name = reader["job_name"].ToString();
                        job.Description = reader["description"].ToString();
                        list.Add(job);
                    }
                }
            }
            return list;
        }

        public Job GetById(int id)
        {
            Job job = new Job();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM JOB WHERE id = " + id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            job.ID = Convert.ToInt32(reader["id"].ToString());
                            job.Job_Name = reader["job_name"].ToString();
                            job.Description = reader["description"].ToString();
                        }
                    }

                }
                connection.Close();
            }
            return job;
        }
        public bool Update(int id, Job t)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE JOB SET job_name = @Job_Name, description = @Description WHERE id = " + id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Job_Name", t.Job_Name);
                    command.Parameters.AddWithValue("@Description", t.Description);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }

            }
        }
        public int GetAutoIncrement()
        {
            int result = -1;
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "SELECT ID from JOB";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No data");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    result = reader.GetInt32(0); // Lấy giá trị cột AUTO_INCREMENT
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result + 1;
        }
        public bool Update(Job t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update JOB set job_name = @job_name, description = @description where id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", t.ID);
                        command.Parameters.AddWithValue("@Job_Name", t.Job_Name);
                        command.Parameters.AddWithValue("@Description", t.Description);
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
