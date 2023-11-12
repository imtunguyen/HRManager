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
                    string query = "INSERT INTO PAYSLIP (employee_id, status, from_date, to_date, total) VALUES (@employee_id, @status, @from_date, @to_date, @total)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", t.employee_id);
                        command.Parameters.AddWithValue("@status", t.status);
                        command.Parameters.AddWithValue("@from_date", t.from_date);
                        command.Parameters.AddWithValue("@to_date", t.to_date);
                        command.Parameters.AddWithValue("@total", t.total);

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

                            list.Add(paySlip);
                        }
                    }

                }
            }
            return list;
        }

        public PaySlipDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaySlipDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
