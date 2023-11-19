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
		public static DepartmentDAO GetInstance()
		{
			return new DepartmentDAO();
		}
		public bool Add(Department t)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Department> GetAll()
		{
			List<Department> des = new List<Department>();
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select * from DEPARTMENT";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Department d = new Department
							{
								ID = Convert.ToInt32(reader["id"]),
								Location_ID = Convert.ToInt32(reader["location_id"]),
								Name = reader["name"].ToString(),
								Address_Detail = reader["address_detail"].ToString(),
							};
							des.Add(d);
						}
					}
				}
			}
			return des;
		}

		public Department GetById(int id)
		{
			Department des = new Department();
			using (SqlConnection conn = DbConnection.GetSqlConnection())
			{
				string query = "select * from DEPARTMENT where id = " + id;
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							des.ID = Convert.ToInt32(reader["id"]);
							des.Location_ID = Convert.ToInt32(reader["location_id"]);
							des.Name = reader["name"].ToString();
							des.Address_Detail = reader["address_detail"].ToString();
						}
					}
				}
			}
			return des;
		}

		public bool Update(Department t)
		{
			throw new NotImplementedException();
		}
	}
}
