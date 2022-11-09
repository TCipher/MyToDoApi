using Microsoft.EntityFrameworkCore;
using MyToDoAPI.Model;

namespace MyToDoAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDos> ToDos { get; set; }

    }
}