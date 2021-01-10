using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negrea_Georgiana_proiect.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int SellerID { get; set; }
        public Seller Seller { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
