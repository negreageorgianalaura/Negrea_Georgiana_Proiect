using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Negrea_Georgiana_proiect.Data;
using Negrea_Georgiana_proiect.Models;

namespace Negrea_Georgiana_proiect.Pages.Products
{
    public class CreateModel : ProductCategoriesPageModel
    {
        private readonly Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext _context;

        public CreateModel(Negrea_Georgiana_proiect.Data.Negrea_Georgiana_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SellerID"] = new SelectList(_context.Set<Seller>(), "ID", "SellerName");
           
            var product = new Product();
            product.ProductCategories = new List<ProductCategory>();

            PopulateAssignedCategoryData(_context, product);
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string[] selectedCategories)
        {
            var newProduct = new Product();
            if (selectedCategories != null)
            {
                newProduct.ProductCategories = new List<ProductCategory>();
                foreach (var cat in selectedCategories)
                {
                    var catToAdd = new ProductCategory
                    {
                        CategoryID = int.Parse(cat)
                    };
                    newProduct.ProductCategories.Add(catToAdd);
                }
            }
            if (await TryUpdateModelAsync<Product>(
            newProduct,
            "Product",
            i => i.Name, i => i.Seller, i => i.Color, i => i.Brand, i => i.Size,
            i => i.Price, i => i.ReleaseDate, i => i.SellerID))
            {
                _context.Product.Add(newProduct);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            PopulateAssignedCategoryData(_context, newProduct);
            return Page();
        }

    }
}
