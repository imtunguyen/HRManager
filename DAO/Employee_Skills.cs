using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Employee_Skills : InterfaceDAO<DTO.Employee_Skills>
    {
        public static Employee_Skills getInstance()
        {
            return new Employee_Skills();
        }
        public bool Add(DTO.Employee_Skills t)
        {
            using(SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "INSERT INTO EMPLOYEE_SKILLS (skill_id, level_id,employee_id, description) VALUES (@skill_id, @level_id, @employee_id, @description)";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@skill_id", t.Skill_ID);
                    command.Parameters.AddWithValue("@level_id", t.Level_ID);
                    command.Parameters.AddWithValue("@employee_id", t.Employee_ID);
                    command.Parameters.AddWithValue("@description", t.description);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            var command = new SqlCommand("DELETE FROM EMPLOYEE_SKILLS WHERE id = @id", DbConnection.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            var result = command.ExecuteNonQuery();
            return result > 0;
        }

        public List<DTO.Employee_Skills> GetAll()
        {
            List<DTO.Employee_Skills> list = new List<DTO.Employee_Skills>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE_SKILLS";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DTO.Employee_Skills e = new DTO.Employee_Skills();
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Skill_ID = Convert.ToInt32(reader["skill_id"].ToString());
                        e.Level_ID = Convert.ToInt32(reader["level_id"].ToString());
                        e.Employee_ID = Convert.ToInt32(reader["id"].ToString());
                        e.description = reader["description"].ToString();
                        list.Add(e);
                    }
                }
            }
            return list;
        }

        public List<DTO.Employee_Skills> GetByEmployeeId(int id)
        {
            List<DTO.Employee_Skills> elist = new List<DTO.Employee_Skills>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE_SKILLS WHERE employee_id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DTO.Employee_Skills e = new DTO.Employee_Skills();
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Skill_ID = Convert.ToInt32(reader["skill_id"].ToString());
                        e.Level_ID = Convert.ToInt32(reader["level_id"].ToString());
                        e.Employee_ID = Convert.ToInt32(reader["employee_id"].ToString());
                        e.description = reader["description"].ToString();
                        elist.Add(e);
                    }
                }
            }
            return elist;
        }
        public DTO.Employee_Skills GetById(int id)
        {
            DTO.Employee_Skills e = new DTO.Employee_Skills();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE_SKILLS WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Skill_ID = Convert.ToInt32(reader["skill_id"].ToString());
                        e.Level_ID = Convert.ToInt32(reader["level_id"].ToString());
                        e.Employee_ID = Convert.ToInt32(reader["employee_id"].ToString());
                        e.description = reader["description"].ToString();
                    }
                }
            }
            return e;
        }

        public bool Update(int id, DTO.Employee_Skills t)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE EMPLOYEE_SKILLS SET skill_id = @skill_id, level_id = @level_id,employee_id = @employee_id, description = @description WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@skill_id", t.Skill_ID);
                    command.Parameters.AddWithValue("@level_id", t.Level_ID);
                    command.Parameters.AddWithValue("@employee_id", t.Employee_ID);
                    command.Parameters.AddWithValue("@description", t.description);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(DTO.Employee_Skills t)
        {
            throw new NotImplementedException();
        }

        DTO.Employee_Skills InterfaceDAO<DTO.Employee_Skills>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
