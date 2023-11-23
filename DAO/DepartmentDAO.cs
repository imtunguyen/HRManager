using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DepartmentDAO : InterfaceDAO<Department>
    {
        public static DepartmentDAO getInstance()
        {
            return new DepartmentDAO();
        }
        public bool Add(Department t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO DEPARTMENT (name, address_detail) " +
                        " VALUES ( @name, @address_detail)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", t.Name);
                        command.Parameters.AddWithValue("@address_detail", t.Address_Detail);
                        int rowsChanged = command.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var command = new SqlCommand("DELETE FROM DEPARTMENT WHERE id = @id", DbConnection.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            var result = command.ExecuteNonQuery();
            return result > 0;
        }
        public List<Department> GetAll(int DeID)
        {
            List<Department> departmentlist = new List<Department>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from DEPARTMENT" +
                    "WHERE id=" + DeID;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Address_Detail = reader["address_detail"].ToString()
                            };
                            departmentlist.Add(department);
                        }
                    }
                }
            }
            return departmentlist;
        }
        public int GetAutoIncrement()
        {
            int result = -1;
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "SELECT id from DEPARTMENT";
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
                                    result = reader.GetInt32(0);
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

        public List<Department> GetAll()
        {
            List<Department> departmentlist = new List<Department>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM DEPARTMENT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Address_Detail = reader["address_detail"].ToString()
                            };
                            departmentlist.Add(department);
                        }
                    }
                }
            }
            return departmentlist;
        }
        public List<Department> GetID()
        {
            List<Department> departmentlist = new List<Department>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT id FROM DEPARTMENT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                ID = Convert.ToInt32(reader["id"]),
                            };
                            departmentlist.Add(department);
                        }
                    }
                }
            }
            return departmentlist;
        }

        public Department GetById(int id)
        {
            Department result = null;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM DEPARTMENT WHERE id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = new Department
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Address_Detail = reader["address_detail"].ToString()
                            };
                        }
                    }
                }
            }
            return result;
        }

        public bool Update(int id, Department t)
        {

                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update DEPARTMENT set name = @name, address_detail = @address_detail where id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", t.Name);
                        command.Parameters.AddWithValue("@address_detail", t.Address_Detail);
                        int rowsChanged = command.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
          
        }
        public int CountEmployee(int departmentId)
        {
            int number = 0;
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "SELECT COUNT(id) FROM EMPLOYEE WHERE department_id = @DepartmentId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentId", departmentId);
                        number = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return number;
        }

        public bool Update(Department t)
        {
            throw new NotImplementedException();
        }
    }
}