using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Negrea_Georgiana_proiect.Data;
using Negrea_Georgiana_proiect.Models;

namespace Negrea_Georgiana_proiect.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext _context;

        public DetailsModel(Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
