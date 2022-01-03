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
    public class DeleteModel : PageModel
    {
        private readonly Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext _context;

        public DeleteModel(Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produs_Make_up Produs_Make_up { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produs_Make_up = await _context.Produs_Make_up.FirstOrDefaultAsync(m => m.ID == id);

            if (Produs_Make_up == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produs_Make_up = await _context.Produs_Make_up.FindAsync(id);

            if (Produs_Make_up != null)
            {
                _context.Produs_Make_up.Remove(Produs_Make_up);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
