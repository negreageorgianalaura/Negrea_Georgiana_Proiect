using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negrea_Georgiana_proiect.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string SellerName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
