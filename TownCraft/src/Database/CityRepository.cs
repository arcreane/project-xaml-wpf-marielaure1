using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TownCraft.Core;

namespace TownCraft.Database
{
    public class CityRepository
    {
        private readonly Database _database;

        public CityRepository(Database database)
        {
            _database = database;
        }

        public void CreateCity(City city)
        {
            using (MySqlConnection connection = _database.OpenConnection())
            {
                string query = "INSERT INTO City (Name, NumberOfCitizen) VALUES (@Name, @NumberOfCitizen)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", city.Name);
                command.Parameters.AddWithValue("@NumberOfCitizen", city.NumberOfCitizen);
                command.ExecuteNonQuery();
            }
        }

        
    }
}
