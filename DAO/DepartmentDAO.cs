using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DepartmentDAO : InterfaceDAO<DepartmentDTO>
    {
        public static DepartmentDAO getInstance() {
            return new DepartmentDAO();
        }
        public bool Add(DepartmentDTO t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO DEPARTMENT (location_id, name, address_detail) " +
                        " VALUES (@location_id, @name, @address_detail)";
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@location_id", t.Location_ID);
                        command.Parameters.AddWithValue("@name", t.Name);
                        command.Parameters.AddWithValue("@address_detail", t.Address_Detail);
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

        public bool Delete(int id)
        {
            var command = new SqlCommand("DELETE FROM DEPARTMENT WHERE id = @id", DbConnection.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            var result = command.ExecuteNonQuery();
            return result > 0;
        }
        public List<DepartmentDTO> GetAll(int DeID)
        {
            List<DepartmentDTO> departmentlist = new List<DepartmentDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from DEPARTMENT"+
                    "WHERE DEPARTMENT.department_id=" + DeID;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DepartmentDTO department = new DepartmentDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Location_ID = Convert.ToInt32(reader["location_id"]),
                                Name = reader["name"].ToString(),
                                Address_Detail = reader["address"].ToString()
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
                    using (SqlCommand command =new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result +1;
        }
        public int CountEmployee(int id)
        {
            int number = 0;
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = " Select count(employee_id) from JOB_DETAIL " +
                        " where department_id = " + id;
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
                                    number=reader.GetInt32(0);
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
            return number;
        }

        public List<DepartmentDTO> GetAll()
        {
            List<DepartmentDTO> departmentlist = new List<DepartmentDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM DEPARTMENT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DepartmentDTO department = new DepartmentDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Location_ID = Convert.ToInt32(reader["location_id"]),
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

        public DepartmentDTO GetById(int id)
        {
            DepartmentDTO result = null;
            using (SqlConnection connection=DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM DEPARTMENT WHERE id=@id";
                using (SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = new DepartmentDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Location_ID = Convert.ToInt32(reader["location_id"]),
                                Name = reader["name"].ToString(),
                                Address_Detail = reader["address_detail"].ToString()
                            };
                        }
                    }
                }
            }
            return result;
        }

        public bool Update(DepartmentDTO t)
        {
            try
            {
                using(SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update DEPARTMENT set name = @name, location_id = @location_id, address_detail = @address_detail where id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id",t.ID);
                        command.Parameters.AddWithValue("@name", t.Name);
                        command.Parameters.AddWithValue("@location_id", t.Location_ID);
                        command.Parameters.AddWithValue("@address_detail", t.Address_Detail);
                        int rowsChanged = command.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        

    }
}
