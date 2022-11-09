using MyToDoAPI.Model;

namespace MyToDoAPI.Interface
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetUsers();
       Task<User> GetUser(int id);
        Task<User> GetUser(string username);
       Task<bool> UserExists(int id);
    }
}
