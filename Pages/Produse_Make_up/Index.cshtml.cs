using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Proiect.Data;
using Barsovan_Narcisa_Proiect.Models;

namespace Barsovan_Narcisa_Proiect.Pages.Produse_Make_up
{
    public class IndexModel : PageModel
    {
        private readonly Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext _context;

        public IndexModel(Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext context)
        {
            _context = context;
        }

        public IList<Produs_Make_up> Produs_Make_up { get;set; }

        public async Task OnGetAsync()
        {
            Produs_Make_up = await _context.Produs_Make_up 
                .Include(b => b.Furnizor)
                .ToListAsync();
        }
    }
}
