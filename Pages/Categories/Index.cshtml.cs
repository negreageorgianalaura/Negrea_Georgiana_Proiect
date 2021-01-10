using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Negrea_Georgiana_proiect.Data;
using Negrea_Georgiana_proiect.Models;

namespace Negrea_Georgiana_proiect.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext _context;

        public IndexModel(Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
