using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;


namespace Exchange.Data.Repository
{
    public class OderDetailRepository : GenericRepository<OrderDetail> {

        public OderDetailRepository() {
        }
        public async Task<List<OrderDetail>> GetAll() {
            return await _dbSet.ToListAsync();
        }
    }
}
