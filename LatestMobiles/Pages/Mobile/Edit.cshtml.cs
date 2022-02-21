using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LatestMobiles.Models;

namespace LatestMobiles.Pages_Mobile
{
    public class EditModel : PageModel
    {
        private readonly LatestMobilesContext _context;

        public EditModel(LatestMobilesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mobiles Mobiles { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobiles = await _context.Mobiles.FirstOrDefaultAsync(m => m.ID == id);

            if (Mobiles == null)
            {
                return NotFound();
            }
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

            _context.Attach(Mobiles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobilesExists(Mobiles.ID))
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

        private bool MobilesExists(int id)
        {
            return _context.Mobiles.Any(e => e.ID == id);
        }
    }
}
