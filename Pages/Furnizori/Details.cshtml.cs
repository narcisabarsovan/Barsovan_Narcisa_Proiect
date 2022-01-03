using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Proiect.Data;
using Barsovan_Narcisa_Proiect.Models;

namespace Barsovan_Narcisa_Proiect.Pages.Furnizori
{
    public class DetailsModel : PageModel
    {
        private readonly Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext _context;

        public DetailsModel(Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext context)
        {
            _context = context;
        }

        public Furnizor Furnizor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Furnizor = await _context.Furnizor.FirstOrDefaultAsync(m => m.ID == id);

            if (Furnizor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
