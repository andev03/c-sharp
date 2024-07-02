using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Exchange.Data.Repository
{
    public class UserHaveRepository : GenericRepository<UserHave>
    {
        public UserHaveRepository() {
        }
        public async Task<List<UserHave>> GetAll() {
            return await _dbSet.ToListAsync();
        }
    }
}
