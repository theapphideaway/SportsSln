using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class StoredDbContext: DbContext
    {
        public StoredDbContext(DbContextOptions<StoredDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
