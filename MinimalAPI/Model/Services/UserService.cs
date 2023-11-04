using MinimalAPI.Model.Dao;
using MinimalAPI.Model.Dao.Exceptions;
using MinimalAPI.Model.Entities;
using MinimalAPI.Model.Services.Exceptions;

namespace MinimalAPI.Model.Services
{
    public class UserService
    {
        private readonly IUserDao _dao;

        public UserService()
        {
            try
            {
                _dao = DaoFactory.CreateUserDao();
            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }

        public User Create(User user)
        {
            try
            {
                return _dao.Create(user);

            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }

        public List<User> FindAll()
        {
            try
            {
                return _dao.FindAll();
            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }

        public User FindById(int id)
        {
            try
            {
                return _dao.FindById(id);
            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }

        public User Update(User user)
        {
            try
            {
                return _dao.Update(user);
            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }

        public User? DeleteById(int id)
        {
            try
            {
                return _dao.DeleteById(id);
            }
            catch (DatabaseException e)
            {
                throw new UserServiceException(e.Message);
            }
        }
    }
}
