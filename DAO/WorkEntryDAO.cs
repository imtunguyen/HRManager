using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WorkEntryDAO : InterfaceDAO<WorkEntry>
    {
        public bool Add(WorkEntry t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO WORK_ENTRY (employee_id, status, input_date) VALUES (@employee_id, @status, @input_date)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", t.employeeId);
                        command.Parameters.AddWithValue("@status", t.status);
                        command.Parameters.AddWithValue("@input_date", t.input_date);

                        int rowsChanged = command.ExecuteNonQuery();
                        return rowsChanged > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkEntry> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkEntry GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(WorkEntry t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update WORK_ENTRY set status = @status where employee_id = @employee_id and input_date = @input_date;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", t.employeeId);
                        command.Parameters.AddWithValue("@input_date", t.input_date);
                        command.Parameters.AddWithValue("@status", t.status);

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

        public bool IsEmployeeDone(string date, int id)
        {
            bool isDone = false;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select employee_id from WORK_ENTRY WHERE status = 'done' and employee_id = "+id+" and input_date = '" + date + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            isDone = true;
                        }
                    }

                }
            }
            return isDone;
        }
        public bool IsEmployeeExistInDatabase(string date, int id)
        {
            bool isExist = false;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select employee_id from WORK_ENTRY WHERE employee_id = " + id + " and input_date = '" + date + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            isExist = true;
                        }
                    }

                }
            }
            return isExist;
        }
        public int getDayOfWork(string dateFrom, string dateTo, int employee_id)
        {
            int d = 0;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select count(employee_id) AS days from WORK_ENTRY where employee_id = "+employee_id+" and input_date between "+"'"+dateFrom+"'"+" and "+"'"+dateTo+"'"+" group by(employee_id)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["days"].ToString() != "")
                            {
                                d = Convert.ToInt32(reader["days"]);
                            }
                        }
                    }
                }
            }
            return d;
        }
    }
}
