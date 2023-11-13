using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BonusAndFinesDAO : InterfaceDAO<BonusAndFines>
    {
        public bool Add(BonusAndFines t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO BONUS_AND_FINES (employee_id, reason, expired_date, type, amount) VALUES (@employee_id, @reason, @expired_date, @type, @amount)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", t.employee_id);
                        command.Parameters.AddWithValue("@amount", t.amount);
                        command.Parameters.AddWithValue("@expired_date", t.expired_date);
                        command.Parameters.AddWithValue("@type", t.type);
                        command.Parameters.AddWithValue("@reason", t.reason);

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

        public List<BonusAndFines> GetAll()
        {
            List<BonusAndFines> list = new List<BonusAndFines>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from BONUS_AND_FINES";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BonusAndFines t = new BonusAndFines();
                            t.id = Convert.ToInt32(reader["id"]);
                            t.employee_id = Convert.ToInt32(reader["employee_id"]);
                            t.reason = reader["reason"].ToString();
                            t.type = reader["type"].ToString();
                            t.expired_date = Convert.ToDateTime(reader["expired_date"]);
                            t.amount = Convert.ToDecimal(reader["amount"]);

                            list.Add(t);
                        }
                    }

                }
            }
            return list;
        }

        public BonusAndFines GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BonusAndFines t)
        {
            throw new NotImplementedException();
        }

        public Decimal getAllBonusOfEmployee(int employee_id, string date)
        {
            Decimal amount = 0;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select sum(amount) AS bonus from BONUS_AND_FINES where employee_id = " + employee_id + " and type = 'bonus' and expired_date >= " + "'" + date + "'" + " group by(employee_id)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["bonus"].ToString() != "")
                            {
                                amount = Convert.ToDecimal(reader["bonus"]);
                            }
                        }
                    }

                }
            }
            return amount;
        }

        public Decimal getAllFinesOfEmployee(int employee_id, string date)
        {
            Decimal amount = 0;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select sum(amount) AS fines from BONUS_AND_FINES where employee_id = " + employee_id + " and type = 'fines' and expired_date >= " + "'" + date + "'" + " group by(employee_id)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["fines"].ToString() != "")
                            {
                                amount = Convert.ToDecimal(reader["fines"]);
                            }
                        }
                    }

                }
            }
            return amount;
        }

        public List<BonusAndFines> Search(string type, string name)
        {
            List<BonusAndFines> list = new List<BonusAndFines>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select b.* from BONUS_AND_FINES as b join EMPLOYEE as e on e.id = b.employee_id where e.name LIKE '"+name+"%' or b.type LIKE '"+type+"%';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BonusAndFines t = new BonusAndFines();
                            t.id = Convert.ToInt32(reader["id"]);
                            t.employee_id = Convert.ToInt32(reader["employee_id"]);
                            t.reason = reader["reason"].ToString();
                            t.type = reader["type"].ToString();
                            t.expired_date = Convert.ToDateTime(reader["expired_date"]);
                            t.amount = Convert.ToDecimal(reader["amount"]);

                            list.Add(t);
                        }
                    }

                }
            }
            return list;
        }

        public List<BonusAndFines> SearchByEmployeeName(string name)
        {
            List<BonusAndFines> list = new List<BonusAndFines>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select b.* from BONUS_AND_FINES as b join EMPLOYEE as e on e.id = b.employee_id where e.name LIKE '"+name+"%';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BonusAndFines t = new BonusAndFines();
                            t.id = Convert.ToInt32(reader["id"]);
                            t.employee_id = Convert.ToInt32(reader["employee_id"]);
                            t.reason = reader["reason"].ToString();
                            t.type = reader["type"].ToString();
                            t.expired_date = Convert.ToDateTime(reader["expired_date"]);
                            t.amount = Convert.ToDecimal(reader["amount"]);

                            list.Add(t);
                        }
                    }

                }
            }
            return list;
        }

        public List<BonusAndFines> SearchByType(string type)
        {
            List<BonusAndFines> list = new List<BonusAndFines>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "select * from BONUS_AND_FINES where type LIKE '"+type+"%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BonusAndFines t = new BonusAndFines();
                            t.id = Convert.ToInt32(reader["id"]);
                            t.employee_id = Convert.ToInt32(reader["employee_id"]);
                            t.reason = reader["reason"].ToString();
                            t.type = reader["type"].ToString();
                            t.expired_date = Convert.ToDateTime(reader["expired_date"]);
                            t.amount = Convert.ToDecimal(reader["amount"]);

                            list.Add(t);
                        }
                    }

                }
            }
            return list;
        }
    }
}
