using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaySlipDAO : InterfaceDAO<PaySlipDTO>
    {
        public bool Add(PaySlipDTO t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO PAYSLIP (employee_id, status, from_date, to_date, total, contract_id) VALUES (@employee_id, @status, @from_date, @to_date, @total, @contract_id)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", t.employee_id);
                        command.Parameters.AddWithValue("@status", t.status);
                        command.Parameters.AddWithValue("@from_date", t.from_date);
                        command.Parameters.AddWithValue("@to_date", t.to_date);
                        command.Parameters.AddWithValue("@total", t.total);
						command.Parameters.AddWithValue("@contract_id", t.Contract_ID);
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

        public List<PaySlipDTO> GetAll()
        {
            List<PaySlipDTO> list = new List<PaySlipDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from PAYSLIP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaySlipDTO paySlip = new PaySlipDTO();
                            paySlip.id = Convert.ToInt32(reader["id"]);
                            paySlip.employee_id = Convert.ToInt32(reader["employee_id"]);
                            paySlip.status = reader["status"].ToString();
                            paySlip.from_date = Convert.ToDateTime(reader["from_date"]);
                            paySlip.to_date = Convert.ToDateTime(reader["to_date"]);
                            paySlip.total = Convert.ToDecimal(reader["total"]);
							paySlip.Contract_ID = Convert.ToInt32(reader["contract_id"]);
							list.Add(paySlip);
                        }
                    }

                }
            }
            return list;
        }

        public PaySlipDTO GetById(int id)
        {
            PaySlipDTO result = new PaySlipDTO();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "select * from Payslip where id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", id);
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							result.id = Convert.ToInt32(reader["id"]);
							result.employee_id = Convert.ToInt32(reader["employee_id"]);
							result.status = reader["status"].ToString();
							result.from_date = Convert.ToDateTime(reader["from_date"]);
							result.to_date = Convert.ToDateTime(reader["to_date"]);
							result.total = Convert.ToDecimal(reader["total"]);
							result.Contract_ID = Convert.ToInt32(reader["contract_id"]);
						}
					}
				}
			}
			return result;

		}

        public bool Update(string status, int id)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "UPDATE PAYSLIP SET status = @status where id = " + id;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
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

        public List<PaySlipDTO> SearchByName(string name) 
        {
            List<PaySlipDTO> list = new List<PaySlipDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select p.* from PAYSLIP as p join EMPLOYEE as e on e.id = p.employee_id where e.name LIKE '%"+name+"%' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaySlipDTO paySlip = new PaySlipDTO();
                            paySlip.id = Convert.ToInt32(reader["id"]);
                            paySlip.employee_id = Convert.ToInt32(reader["employee_id"]);
                            paySlip.status = reader["status"].ToString();
                            paySlip.from_date = Convert.ToDateTime(reader["from_date"]);
                            paySlip.to_date = Convert.ToDateTime(reader["to_date"]);
                            paySlip.total = Convert.ToDecimal(reader["total"]);
							paySlip.Contract_ID = Convert.ToInt32(reader["contract_id"]);
							list.Add(paySlip);
                        }
                    }

                }
            }
            return list;
        }
        public List<PaySlipDTO> Search(string name, string status)
        {
            List<PaySlipDTO> list = new List<PaySlipDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select p.* from PAYSLIP as p join EMPLOYEE as e on e.id = p.employee_id where e.name LIKE '%"+name+"%' or p.status LIKE '%"+status+"%';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaySlipDTO paySlip = new PaySlipDTO();
                            paySlip.id = Convert.ToInt32(reader["id"]);
                            paySlip.employee_id = Convert.ToInt32(reader["employee_id"]);
                            paySlip.status = reader["status"].ToString();
                            paySlip.from_date = Convert.ToDateTime(reader["from_date"]);
                            paySlip.to_date = Convert.ToDateTime(reader["to_date"]);
                            paySlip.total = Convert.ToDecimal(reader["total"]);
							paySlip.Contract_ID = Convert.ToInt32(reader["contract_id"]);

							list.Add(paySlip);
                        }
                    }

                }
            }
            return list;
        }

        public List<PaySlipDTO> SearchByStatus(string status)
        {
            List<PaySlipDTO> list = new List<PaySlipDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from PAYSLIP where status LIKE '%"+status+"%';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaySlipDTO paySlip = new PaySlipDTO();
                            paySlip.id = Convert.ToInt32(reader["id"]);
                            paySlip.employee_id = Convert.ToInt32(reader["employee_id"]);
                            paySlip.status = reader["status"].ToString();
                            paySlip.from_date = Convert.ToDateTime(reader["from_date"]);
                            paySlip.to_date = Convert.ToDateTime(reader["to_date"]);
                            paySlip.total = Convert.ToDecimal(reader["total"]);
							paySlip.Contract_ID = Convert.ToInt32(reader["contract_id"]);
							list.Add(paySlip);
                        }
                    }

                }
            }
            return list;
        }

        public bool Update(PaySlipDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
