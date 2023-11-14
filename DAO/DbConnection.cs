using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DbConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionsString = "Data Source=Diggory;Initial Catalog=HRM;Persist Security Info=True;User ID=diggory;Password=123456";

            var sqlConn = new SqlConnection(connectionsString);
            if (sqlConn.State == System.Data.ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            else
            {
                sqlConn.Close();
            }
            return sqlConn;
        }
    }
}
