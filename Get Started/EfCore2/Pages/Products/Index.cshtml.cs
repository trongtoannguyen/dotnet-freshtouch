using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EfCoreGetStarted.Data;
using EfCoreGetStarted.Models;

namespace EfCore2.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly EfCoreGetStarted.Data.HamburgPizzaDbContext _context;

        public IndexModel(EfCoreGetStarted.Data.HamburgPizzaDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
