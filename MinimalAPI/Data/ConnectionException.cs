namespace MinimalAPI.Data
{
    public class ConnectionException : ApplicationException
    {
        public ConnectionException(string msg) : base(msg) { }
    }
}
