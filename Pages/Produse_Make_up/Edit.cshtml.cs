using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Proiect.Data;
using Barsovan_Narcisa_Proiect.Models;

namespace Barsovan_Narcisa_Proiect.Pages.Produse_Make_up
{
    public class EditModel : PageModel
    {
        private readonly Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext _context;

        public EditModel(Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext context)
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
            ViewData["FurnizorID"] = new SelectList(_context.Set<Furnizor>(), "ID", "Nume_Furnizor");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produs_Make_up).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Produs_Make_upExists(Produs_Make_up.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Produs_Make_upExists(int id)
        {
            return _context.Produs_Make_up.Any(e => e.ID == id);
        }
    }
}
