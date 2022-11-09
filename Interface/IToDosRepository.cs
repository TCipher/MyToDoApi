using MyToDoAPI.Model;

namespace MyToDoAPI.Interface
{
    public interface IToDosRepository
    {
       Task<ICollection<ToDos>> GetToDos();
       Task<ICollection<ToDos>>GetToDosByUser(int userId);
        Task<bool> UserExists(int userId);
    }
}
