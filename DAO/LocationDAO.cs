using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LocationDAO : InterfaceDAO<Location>
    {
        public static LocationDAO getInstance()
        {
            return new LocationDAO();
        }
        public Location GetById(int id)
        {
            Location result = null;
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM LOCATION WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = new Location
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Address = reader["address"].ToString()
                            };
                        }
                    }
                }
            }
            return result;
        }
        public bool Add(Location t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAll()
        {
            List<Location> listLoca = new List<Location>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = " SELECT * FROM LOCATION ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Location loca = new Location
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Address = reader["address"].ToString()
                            };
                            listLoca.Add(loca);
                        }
                    }
                }
            }
            return listLoca;
        }



        public bool Update(Department t)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "update DEPARTMENT set name = @name, location_id = @location_id, address_detail = @address_detail where id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", t.ID);
                        command.Parameters.AddWithValue("@name", t.Name);
                        command.Parameters.AddWithValue("@location_id", t.Location_ID);
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

        public bool Update(Location t)
        {
            throw new NotImplementedException();
        }
    }
}
