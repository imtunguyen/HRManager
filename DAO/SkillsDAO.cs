using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SkillsDAO : InterfaceDAO<Skills>
    {
        public bool Add(Skills skill)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "INSERT INTO SKILL (name, description) VALUES (@Name, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", skill.Skills_Name);
                command.Parameters.AddWithValue("@Description", skill.description);

                try
                {
                    int newId = Convert.ToInt32(command.ExecuteScalar());
                    skill.ID = newId;
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding skill: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "DELETE FROM SKILL WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting skill: " + ex.Message);
                    return false;
                }
            }
        }

        public List<Skills> GetAll()
        {
            List<Skills> skillsList = new List<Skills>();

            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM SKILL";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Skills skill = new Skills
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Skills_Name = Convert.ToString(reader["name"]),
                                description = Convert.ToString(reader["description"])
                            };
                            skillsList.Add(skill);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting skills: " + ex.Message);
                }
            }

            return skillsList;
        }

        public Skills GetById(int id)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM SKILL WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Skills
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Skills_Name = Convert.ToString(reader["name"]),
                                description = Convert.ToString(reader["description"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting skill by ID: " + ex.Message);
                }

                return null;
            }
        }

        public bool Update(Skills skill)
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "UPDATE SKILL SET name = @Name, description = @Description WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", skill.Skills_Name);
                command.Parameters.AddWithValue("@Description", skill.description);
                command.Parameters.AddWithValue("@Id", skill.ID);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating skill: " + ex.Message);
                    return false;
                }
            }
        }
        public int GetMaxSkillId()
        {
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT MAX(id) FROM SKILL";
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
