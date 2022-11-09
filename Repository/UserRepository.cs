using Microsoft.EntityFrameworkCore;
using MyToDoAPI.Data;
using MyToDoAPI.Interface;
using MyToDoAPI.Model;

namespace MyToDoAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        // defining a private field
        //this will help us have access to our datacontext
        private readonly DataContext _context;
        public UserRepository(DataContext  context)
        {
            _context = context;
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return  await _context.Users.OrderBy(x => x.Id).ToListAsync();

        }

       
    }
}
