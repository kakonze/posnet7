using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using posnet7.Models;

namespace Posnet7.Data
{
    public class SupplierSupplierContext : DbContext
    {
        public SupplierSupplierContext(DbContextOptions<SupplierSupplierContext> options)
            : base(options)
        {
        }

        public DbSet<posnet7.Models.Supplier> Supplier { get; set; } = default!;
    }
}
