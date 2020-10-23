using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EfStoreRepository : IStoreRepository
    {
        private StoredDbContext context;

        public EfStoreRepository(StoredDbContext _context)
        {
            context = _context;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
