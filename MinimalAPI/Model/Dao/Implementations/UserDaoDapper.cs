using Dapper.Contrib.Extensions;
using MinimalAPI.Model.Entities;
using MinimalAPI.Model.Dao.Exceptions;
using MySql.Data.MySqlClient;
using System.Data;

namespace MinimalAPI.Model.Dao.Implementations
{
    public class UserDaoDapper : IUserDao
    {
        private readonly IDbConnection _connection;
        public UserDaoDapper(IDbConnection connection)
        {
            try
            {
                _connection = connection;
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }

        public User Create(User user)
        {
            try
            {
                _connection.Insert(user);
                return user;
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }

        public List<User> FindAll()
        {
            try
            {
                return _connection.GetAll<User>().ToList();
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }

        public User FindById(int id)
        {
            try
            {
                return _connection.Get<User>(id);
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }

        public User Update(User user)
        {
            try
            {
                User userInDb = _connection.Get<User>(user.Id);
                if (user != null)
                {
                    userInDb.Name = user.Name;
                    userInDb.Email = user.Email;
                    userInDb.Password = user.Password;
                    _connection.Update(userInDb);
                }
                return userInDb;
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }

        public User DeleteById(int id)
        {
            try
            {
                User user = FindById(id);
                if (user != null)
                {
                    _connection.Delete(user);
                }
                return user;
            }
            catch (MySqlException e)
            {
                throw new DatabaseException(e.Message);
            }
        }
    }
}
