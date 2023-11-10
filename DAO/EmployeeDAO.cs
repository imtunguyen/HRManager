using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDAO : InterfaceDAO<EmployeeDTO>
    {
        public static EmployeeDAO getInstance()
        {
            return new EmployeeDAO();
        }
        public bool Add(EmployeeDTO t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            using(SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeDTO e = new EmployeeDTO();
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Name = reader["Name"].ToString();
                        e.Gender = reader["gender"].ToString();
                        e.Date_of_Birth = DateTime.Parse(reader["date_Of_Birth"].ToString());
                        e.Day_Joined = DateTime.Parse(reader["date_joined"].ToString());
                        //e.Day_Left = DateTime.Parse(reader["date_left"].ToString());
                        e.Phone = Convert.ToInt32(reader["phone"].ToString());
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.base_pay = Convert.ToDouble(reader["base_pay"]);
                        e.Status = reader["status"].ToString();
                        list.Add(e);
                    }
                }
            }
            return list;
        }

        public EmployeeDTO GetById(int id)
        {
            EmployeeDTO e = new EmployeeDTO();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE WHERE @id = "+id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Name = reader["Name"].ToString();
                        e.Gender = reader["gender"].ToString();
                        e.Date_of_Birth = DateTime.Parse(reader["date_Of_Birth"].ToString());
                        e.Day_Joined = DateTime.Parse(reader["date_joined"].ToString());
                        e.Day_Left = DateTime.Parse(reader["date_left"].ToString());
                        e.Phone = Convert.ToInt32(reader["phone"].ToString());
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.base_pay = Convert.ToDouble(reader["base_pay"]);
                        e.Status = reader["status"].ToString();
                    }
                }
                connection.Close();
            }
            return e;
        }

        public bool Update(EmployeeDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
