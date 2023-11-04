using MySql.Data.MySqlClient;

namespace MinimalAPI.Data
{
    public class Database
    {
        private static MySqlConnection? _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection == null)
            {
                try
                {
                    _connection = new MySqlConnection("Server=localhost;User ID=root;Password=Ar@1998!#;Database=testedb");
                    _connection.Open();
                }
                catch(MySqlException)
                {
                    throw new ConnectionException("Falha na conexão com o banco de dados.");
                }
            }
            return _connection;
        }
    }
}

