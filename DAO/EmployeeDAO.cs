using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
                string query = "INSERT INTO EMPLOYEE (name, gender, date_Of_Birth, phone, email, img_path, status) VALUES (@Name, @Gender, @Date_Of_Birth, @Phone, @Email, @img_path, @Status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", t.Name);
                    command.Parameters.AddWithValue("@Gender", t.Gender);
                    command.Parameters.AddWithValue("@Date_Of_Birth", t.Date_of_Birth);
                    command.Parameters.AddWithValue("@Phone", t.Phone);
                    command.Parameters.AddWithValue("@Email", t.Email);
                    if (!string.IsNullOrEmpty(t.img_path))
                    {
                        command.Parameters.AddWithValue("@img_path", t.img_path);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@img_path", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@Status", t.Status);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool Delete(int id)
        {
            var command = new SqlCommand("DELETE FROM EMPLOYEE WHERE id = @id", DbConnection.GetSqlConnection());
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
                        DateTime dateJoined;
                        e.Date_Joined = DateTime.TryParse(reader["date_joined"].ToString(), out dateJoined) ? dateJoined : null;
                        // Thay thế bằng
                        if (DateTime.TryParse(reader["date_joined"].ToString(), out dateJoined))
                        {
                            e.Date_Joined = dateJoined;
                        }
                        DateTime dateLeft;
                        e.Date_Left = DateTime.TryParse(reader["date_left"].ToString(), out dateLeft) ? dateLeft : null;

                        // Thay thế bằng
                        if (DateTime.TryParse(reader["date_left"].ToString(), out dateLeft))
                        {
                            e.Date_Left = dateLeft;
                        }
                        else
                        {
                            e.Date_Left = null;
                        }
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
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
                        DateTime dateJoined;
                        e.Date_Left = DateTime.TryParse(reader["date_left"].ToString(), out dateJoined) ? dateJoined : null;

                        // Thay thế bằng
                        if (DateTime.TryParse(reader["date_left"].ToString(), out dateJoined))
                        {
                            e.Date_Joined = dateJoined;
                        }
                        else
                        {
                            e.Date_Joined = null;
                        }
                        DateTime dateLeft;
                        e.Date_Left = DateTime.TryParse(reader["date_left"].ToString(), out dateLeft) ? dateLeft : null;

                        // Thay thế bằng
                        if (DateTime.TryParse(reader["date_left"].ToString(), out dateLeft))
                        {
                            e.Date_Left = dateLeft;
                        }
                        else
                        {
                            e.Date_Left = null;
                        }
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Status = reader["status"].ToString();
                    }
                }
            }
            return e;
        }

        public bool Update(int id, EmployeeDTO employee)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE EMPLOYEE SET name = @Name, gender = @Gender, date_Of_Birth = @Date_Of_Birth, date_left = @Date_Left, phone = @Phone, email = @Email, img_path = @img_path, status = @Status WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@Date_Of_Birth", employee.Date_of_Birth);
                    command.Parameters.AddWithValue("@Phone", employee.Phone);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    if (employee.Date_Left.HasValue)
                    {
                        command.Parameters.AddWithValue("@Date_Left", employee.Date_Left.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Date_Left", DBNull.Value);
                    }
                    if (!string.IsNullOrEmpty(employee.img_path))
                    {
                        command.Parameters.AddWithValue("@img_path", employee.img_path);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@img_path", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@Status", employee.Status);
                    command.Parameters.AddWithValue("@id", id);
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




