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
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "INSERT INTO EMPLOYEE (name, gender, date_Of_Birth, day_joined, phone, email, img_path, status) VALUES (@Name, @Gender, @Date_Of_Birth, @Day_Joined, @Phone, @Email, @img_path, @Status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", t.Name);
                    command.Parameters.AddWithValue("@Gender", t.Gender);
                    command.Parameters.AddWithValue("@Date_Of_Birth", t.Date_of_Birth);
                    command.Parameters.AddWithValue("@Day_Joined", t.Day_Joined);
                    command.Parameters.AddWithValue("@Phone", t.Phone);
                    command.Parameters.AddWithValue("@Email", t.Email);
                    command.Parameters.AddWithValue("@img_path", t.img_path);

                    command.Parameters.AddWithValue("@Status", t.Status);
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

        public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM EMPLOYEE";
                using (SqlCommand command = new SqlCommand(query, connection))
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
                        e.Phone = reader["phone"].ToString();
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
                string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        e.ID = Convert.ToInt32(reader["id"].ToString());
                        e.Name = reader["Name"].ToString();
                        e.Gender = reader["gender"].ToString();
                        e.Date_of_Birth = DateTime.Parse(reader["date_Of_Birth"].ToString());
                        e.Day_Joined = DateTime.Parse(reader["date_joined"].ToString());
                        e.Day_Left = reader["date_left"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["date_left"]);
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Status = reader["status"].ToString();
                    }
                }
            }
            return e;
        }

        public bool Update(int id, EmployeeDTO t)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE EMPLOYEE SET name = @Name, gender = @Gender, date_Of_Birth = @Date_Of_Birth, day_joined = @Day_Joined, day_left = @Day_Left, phone = @Phone, email = @Email, img_path = @img_path, status = @Status WHERE @ID = " + id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", t.Name);
                    command.Parameters.AddWithValue("@Gender", t.Gender);
                    command.Parameters.AddWithValue("@Date_Of_Birth", t.Date_of_Birth);
                    command.Parameters.AddWithValue("@Day_Joined", t.Day_Joined);
                    command.Parameters.AddWithValue("@Phone", t.Phone);
                    command.Parameters.AddWithValue("@Email", t.Email);
                    command.Parameters.AddWithValue("@img_path", t.img_path);
                    command.Parameters.AddWithValue("@Status", t.Status);
                    command.Parameters.AddWithValue("@ID", id);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool Update(EmployeeDTO t)
        {
            throw new NotImplementedException();
        }
    }
}