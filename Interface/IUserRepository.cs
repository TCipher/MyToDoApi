using MyToDoAPI.Model;

namespace MyToDoAPI.Interface
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetUsers();
    }
}
