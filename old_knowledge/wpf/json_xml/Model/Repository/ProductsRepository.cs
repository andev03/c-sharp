using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;


namespace Exchange.Data.Repository
{
    public class ProductsRepository: GenericRepository<Product>
    {
        public ProductsRepository() {
        }
        public async Task<List<Product>> GetAll() {
            return await _dbSet.ToListAsync();
        }
    }
}
