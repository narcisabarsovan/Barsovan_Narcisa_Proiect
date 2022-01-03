using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Proiect.Models;

namespace Barsovan_Narcisa_Proiect.Data
{
    public class Barsovan_Narcisa_ProiectContext : DbContext
    {
        public Barsovan_Narcisa_ProiectContext (DbContextOptions<Barsovan_Narcisa_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Barsovan_Narcisa_Proiect.Models.Produs_Make_up> Produs_Make_up { get; set; }

        public DbSet<Barsovan_Narcisa_Proiect.Models.Furnizor> Furnizor { get; set; }

        public DbSet<Barsovan_Narcisa_Proiect.Models.Categorie> Categorie { get; set; }
    }
}
