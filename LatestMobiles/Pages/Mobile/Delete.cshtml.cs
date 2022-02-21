using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LatestMobiles.Models;

namespace LatestMobiles.Pages_Mobile
{
    public class DeleteModel : PageModel
    {
        private readonly LatestMobilesContext _context;

        public DeleteModel(LatestMobilesContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobiles = await _context.Mobiles.FindAsync(id);

            if (Mobiles != null)
            {
                _context.Mobiles.Remove(Mobiles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
