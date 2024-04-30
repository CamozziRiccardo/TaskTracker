
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TaskTracker
{
    internal class DatabaseManager
    {
        private string connectionString {  get; set; }

        public DatabaseManager(string hostname, string username, string password, string database)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = hostname;
            builder.UserID = username;
            builder.Password = password;
            builder.InitialCatalog = database;
            connectionString = builder.ConnectionString;
        }

        public bool CreaUtente(string username, string password, string jsonData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Utenti (username, password, json_data, created_at) VALUES (@Username, @Password, @JsonData, GETDATE())";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@JsonData", jsonData);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool VerificaEsistenzaUtente(int id, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Utenti WHERE id = @Id AND password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
