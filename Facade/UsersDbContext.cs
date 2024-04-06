using Facade.Models;
using Microsoft.EntityFrameworkCore;

namespace Facade
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
