using MySql.Data.MySqlClient;
using System;

namespace TownCraft.Database
{
    public class Database
    {
        private readonly string _connectionString = "server=;port=;database=;user=;password=";

        public MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                throw;
            }
            return connection;
        }

        public void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
