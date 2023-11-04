using MinimalAPI.Data;
using MinimalAPI.Model.Dao.Exceptions;
using MinimalAPI.Model.Dao.Implementations;

namespace MinimalAPI.Model.Dao
{
    public class DaoFactory
    {
        public static IUserDao CreateUserDao()
        {
            try
            {
                return new UserDaoDapper(Database.GetConnection());
            }
            catch (ConnectionException e)
            {
                throw new DatabaseException(e.Message);
            }
        }
    }
}
