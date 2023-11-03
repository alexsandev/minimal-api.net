using MySql.Data.MySqlClient;

namespace MinimalAPI
{
    public class Database
    {
        private static MySqlConnection? _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection("Server=localhost;User ID=root;Password=Ar@1998!#;Database=testedb");
                _connection.Open();
            }
            return _connection;
        }

    }
}

