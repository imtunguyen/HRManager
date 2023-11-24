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
                string query = "INSERT INTO EMPLOYEE (name, gender, date_Of_Birth, phone, email, img_path, department_id, status) VALUES (@Name, @Gender, @Date_Of_Birth, @Phone, @Email, @img_path,@Department_id, @Status)";
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
                    command.Parameters.AddWithValue("@Department_id", t.Department_id);
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
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Department_id = Convert.ToInt32(reader["Department_id"].ToString());
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
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Department_id = Convert.ToInt32(reader["Department_id"].ToString());
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
                string query = "UPDATE EMPLOYEE SET name = @Name, gender = @Gender, date_Of_Birth = @Date_Of_Birth, phone = @Phone, email = @Email, img_path = @img_path,department_id = @Department_id, status = @Status WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@Date_Of_Birth", employee.Date_of_Birth);
                    command.Parameters.AddWithValue("@Phone", employee.Phone);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    if (!string.IsNullOrEmpty(employee.img_path))
                    {
                        command.Parameters.AddWithValue("@img_path", employee.img_path);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@img_path", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@Status", employee.Status);
                    command.Parameters.AddWithValue("@Department_id", employee.Department_id);
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

        public List<EmployeeDTO> GetEmployeeHaveContractRunning()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select e.* from EMPLOYEE as e join CONTRACT as c on c.employee_id = e.id where c.status = 'Running'";
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
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Department_id = Convert.ToInt32(reader["Department_id"].ToString());
                        e.Status = reader["status"].ToString();
                        list.Add(e);
                    }
                }
            }
            return list;
        }

        public List<EmployeeDTO> searchByName(string name)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from EMPLOYEE where name LIKE '"+name+"%'";
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
                        e.Phone = reader["phone"].ToString();
                        e.Email = reader["email"].ToString();
                        e.img_path = reader["img_path"].ToString();
                        e.Department_id = Convert.ToInt32(reader["Department_id"].ToString());
                        e.Status = reader["status"].ToString();
                        list.Add(e);
                    }
                }
            }
            return list;
        }
    }
}




