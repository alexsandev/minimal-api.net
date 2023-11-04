namespace MinimalAPI.Model.Services.Exceptions
{
    public class UserServiceException : ApplicationException
    {
        public UserServiceException(string msg) : base(msg){ }
    }
}
