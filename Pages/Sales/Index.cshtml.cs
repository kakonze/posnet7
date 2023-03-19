using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using posnet7.Data;
using posnet7.Models;

namespace posnet7.Pages_Sales
{
    public class IndexModel : PageModel
    {
        private readonly posnet7.Data.SaleDbContext _context;

        public IndexModel(posnet7.Data.SaleDbContext context)
        {
            _context = context;
        }

        public IList<Sale> Sale { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Sale != null)
            {
                Sale = await _context.Sale.ToListAsync();
            }
        }
    }
}
