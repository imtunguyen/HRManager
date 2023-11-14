using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO : InterfaceDAO<Account>
    {
        public int newIdOfUser = -1;
        public bool Add(Account t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "INSERT INTO users (username, password, createDate) VALUES (@username, @password, @createDate) SELECT @@IDENTITY AS id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", t.Username);
                        command.Parameters.AddWithValue("@password", t.Password);
                        command.Parameters.AddWithValue("@createDate", t.Create_Date);

                        int id = Convert.ToInt32(command.ExecuteScalar());
                        newIdOfUser = id;
                        return id > 0;
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

        public List<Account> GetAll()
        {
            List<Account> List = new List<Account>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM ACCOUNT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account ac = new Account();
                            ac.Username = reader["username"].ToString();
                            ac.Password = reader["password"].ToString();
                            ac.Employee_ID = Convert.ToInt32(reader["employee_id"]);
                            
                            if (reader["create_Date"].ToString() != "")
                            {
                                ac.Create_Date = Convert.ToDateTime(reader["createDate"]);
                            }

                            List.Add(ac);
                        }
                    }

                }
                connection.Close();
            }
            return List;
        }
        public bool isExistUsername(string s)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM ACCOUNT WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", s);
                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public int GetIdByUsername(string username)
        {
            int Id = -1;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT employee_id FROM ACCOUNT WHERE username = '" + username + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["employee_id"]);
                        }
                    }

                }
                connection.Close();
            }
            return Id;
        }
        public List<Account> GetUserName(string s)
        {
            List<Account> users = new List<Account>();

            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "SELECT username FROM ACCOUNT WHERE username = @input";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@input", s);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Account user = new Account();
                                user.Username = reader["username"].ToString();
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return users;
        }
        public void UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE ACCOUNT SET password = @newPassword WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.ExecuteNonQuery();
                }
            }
        }
        public Account GetById(int id)
        {
            Account acc = new Account();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM ACCOUNT WHERE employee_id = " + id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            acc.Employee_ID = Convert.ToInt32(reader["employee_id"]);
                            
                            
                            if (reader["createDate"].ToString() != "")
                            {
                                acc.Create_Date = Convert.ToDateTime(reader["createDate"]);
                            }
                            acc.Username = reader["username"].ToString();
                            acc.Password = reader["password"].ToString();
                            
                        }
                    }

                }
                connection.Close();
            }
            return acc;
        }
        //public void LockAcc(string username)
        //{
        //    using (SqlConnection connection = DbConnection.GetSqlConnection())
        //    {
                
        //        string query = "UPDATE ACCOUNT SET Locked = 1 WHERE Username = @Username";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Username", username);
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        public bool Update(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
