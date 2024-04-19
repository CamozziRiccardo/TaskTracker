using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TaskTracker
{
    internal class MySQL
    {
        string connectionString { get; set; }

        public MySQL()
        {
            connectionString = "Server=Localhost;Database=il_tuo_nome_database;Uid=il_tuo_nome_utente;Pwd=la_tua_password;";
        }

        public string getData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM users";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("ID: {0}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Errore: " + ex.Message);
                }
            }
            return null;
        }
        public void passData(string username, string password)
        {

        }
    }
}
