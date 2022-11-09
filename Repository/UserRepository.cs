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

        //Returns a single user
        public async Task<User> GetUser(int id)
        {
           return await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User> GetUser(string username)
        {
            return await _context.Users.Where(u => u.LastName == username).FirstOrDefaultAsync();
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return  await _context.Users.OrderBy(x => x.Id).ToListAsync();

        }

       public async Task<bool> UserExists(int id)
        {
           return await _context.Users.AnyAsync(p => p.Id == id);
        }

       
    }
}
