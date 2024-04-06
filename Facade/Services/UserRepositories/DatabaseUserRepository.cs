using Facade.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Facade.Services.UserRepositories
{
    public class DatabaseUserRepository
    {
        private readonly UsersDbContext context;

        public DatabaseUserRepository(UsersDbContext context)
        {
            this.context = context;
        }

        public async Task<User> GetByUsername(string username)
        {
            return await this.context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
