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
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            throw new NotImplementedException();
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
