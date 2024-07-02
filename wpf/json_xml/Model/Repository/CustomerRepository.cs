using Exchange.Data.Base;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Exchange.Data.Repository {
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository() { }


        public async Task<List<Customer>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

    }
}
