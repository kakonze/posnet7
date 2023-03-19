using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using posnet7.Models;

namespace posnet7.Data
{
    public class SaleDbContext : DbContext
    {
        public SaleDbContext (DbContextOptions<SaleDbContext> options)
            : base(options)
        {
        }

        public DbSet<posnet7.Models.Sale> Sale { get; set; } = default!;
    }
}
