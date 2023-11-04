using MinimalAPI.Model.Entities;

namespace MinimalAPI.Model.Dao
{
    public interface IUserDao
    {
        User Create(User user);
        List<User> FindAll();
        User FindById(int id);
        User Update(User user);
        User DeleteById(int id);
    }
}
