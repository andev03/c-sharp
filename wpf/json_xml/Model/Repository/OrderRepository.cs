using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;


namespace Exchange.Data.Repository
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository() {
        }
        public async Task<List<Order>> GetAll() {
            return await _dbSet.ToListAsync();
        }
    }
}
