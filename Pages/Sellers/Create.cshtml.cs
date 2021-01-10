using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Negrea_Georgiana_proiect.Data;
using Negrea_Georgiana_proiect.Models;

namespace Negrea_Georgiana_proiect.Pages.Sellers
{
    public class CreateModel : PageModel
    {
        private readonly Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext _context;

        public CreateModel(Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Seller Seller { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Seller.Add(Seller);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
