using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;


namespace Exchange.Data.Repository
{
    public class UserWantRepository :GenericRepository<UserWant>
    {
        public UserWantRepository() {
        }
        public async Task<List<UserWant>> GetAll() {
            return await _dbSet.ToListAsync();
        }
    }
}
