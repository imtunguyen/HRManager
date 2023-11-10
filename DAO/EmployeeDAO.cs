using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDAO : InterfaceDAO<Employee>
    {
        public bool Add(Employee t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from EMPLOYEE";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Name = reader["name"].ToString();
                            employee.ID = Convert.ToInt32(reader["id"]);
                            employee.Email = reader["email"].ToString();
                            employee.Status = reader["status"].ToString();
                            employee.img_path = reader["status"].ToString();
                            employee.base_pay = Convert.ToDouble(reader["base_pay"]);
                            employee.Gender = reader["gender"].ToString();
                            employee.Phone = Convert.ToInt32(reader["phone"]);
                            DateTime dateJoin = Convert.ToDateTime(reader["date_joined"]);
                            if (reader["date_left"].ToString() != "")
                            {
                                DateTime dateLeft = Convert.ToDateTime(reader["date_left"]);
                                employee.Day_Left = DateOnly.FromDateTime(dateLeft);
                            }
                            DateTime dateOfBirth = Convert.ToDateTime(reader["date_Of_Birth"]);
                            employee.Day_Joined = DateOnly.FromDateTime(dateJoin);
                            employee.Date_of_Birth = DateOnly.FromDateTime(dateOfBirth);
                            list.Add(employee);
                        }
                    }

                }
            }
            return list;
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
