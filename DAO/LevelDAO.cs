using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LevelDAO : InterfaceDAO<Level>
    {
        public bool Add(Level level)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "INSERT INTO LEVEL (level) VALUES (@LevelName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LevelName", level.Level_Name);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "DELETE FROM LEVEL WHERE id = @LevelID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LevelID", id);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public List<Level> GetAll()
        {
            List<Level> levels = new List<Level>();

            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM LEVEL";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Level level = new Level
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Level_Name = Convert.ToString(reader["level"])
                        };

                        levels.Add(level);
                    }
                }
            }

            return levels;
        }

        public Level GetById(int id)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM LEVEL WHERE id = @LevelID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LevelID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Level
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Level_Name = Convert.ToString(reader["level"])
                        };
                    }

                    return null; // If no matching record is found
                }
            }
        }

        public bool Update(Level level)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE LEVEL SET level = @LevelName WHERE id = @LevelID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LevelID", level.ID);
                command.Parameters.AddWithValue("@LevelName", level.Level_Name);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public int GetMaxLevelId()
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT MAX(id) FROM LEVEL";
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0; // If no records are found or if the result is null
            }
        }



    }
}
