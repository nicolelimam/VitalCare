using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace VitalCare
{
    public class Conexao
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string id;
        private string password;

        public Conexao()
        {
            server = "localhost";
            database = "vitalcare";
            id = "root";
            password = "";
        }

        public MySqlConnection IniciarConexao()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={id};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Conexão estabelecida com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao estabelecer conexão: ");
            }

            return connection;
        }
    }
}
