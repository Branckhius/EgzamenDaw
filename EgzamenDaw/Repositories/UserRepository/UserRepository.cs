using EgzamenDaw.Data;
using EgzamenDaw.Models;
using EgzamenDaw.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace EgzamenDaw.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Lab4Context lab4Context) : base(lab4Context)
        {
        }

        public async Task<List<User>> FindAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<User> FindByUsername(string username)
        {
            return (await _table.FirstOrDefaultAsync(u => u.Username.Equals(username)))!;
        }

    }
}
