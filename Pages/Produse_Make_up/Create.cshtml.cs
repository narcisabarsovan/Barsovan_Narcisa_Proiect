using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Barsovan_Narcisa_Proiect.Data;
using Barsovan_Narcisa_Proiect.Models;

namespace Barsovan_Narcisa_Proiect.Pages.Produse_Make_up
{
    public class CreateModel : PageModel
    {
        private readonly Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext _context;

        public CreateModel(Barsovan_Narcisa_Proiect.Data.Barsovan_Narcisa_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["FurnizorID"] = new SelectList(_context.Set<Furnizor>(), "ID", "Nume_Furnizor");
            return Page();
        }

        [BindProperty]
        public Produs_Make_up Produs_Make_up { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produs_Make_up.Add(Produs_Make_up);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
