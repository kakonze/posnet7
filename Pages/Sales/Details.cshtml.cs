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
    public class DetailsModel : PageModel
    {
        private readonly posnet7.Data.SaleDbContext _context;

        public DetailsModel(posnet7.Data.SaleDbContext context)
        {
            _context = context;
        }

      public Sale Sale { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sale == null)
            {
                return NotFound();
            }

            var sale = await _context.Sale.FirstOrDefaultAsync(m => m.ID == id);
            if (sale == null)
            {
                return NotFound();
            }
            else 
            {
                Sale = sale;
            }
            return Page();
        }
    }
}
