namespace MinimalAPI.Model.Dao.Exceptions
{
    public class DatabaseException : ApplicationException
    {
        public DatabaseException(string msg) : base(msg) { }
    }
}
