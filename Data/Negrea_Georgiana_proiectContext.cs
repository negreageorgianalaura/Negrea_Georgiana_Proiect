using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Negrea_Georgiana_proiect.Models;

namespace Negrea_Georgiana_proiect.Data
{
    public class Negrea_Georgiana_proiectContext : DbContext
    {
        public Negrea_Georgiana_proiectContext (DbContextOptions<Negrea_Georgiana_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<Negrea_Georgiana_proiect.Models.Product> Product { get; set; }

        public DbSet<Negrea_Georgiana_proiect.Models.Seller> Seller { get; set; }

        public DbSet<Negrea_Georgiana_proiect.Models.Category> Category { get; set; }
    }
}
