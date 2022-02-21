using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LatestMobiles.Models;

namespace LatestMobiles.Pages_Mobile
{
    public class CreateModel : PageModel
    {
        private readonly LatestMobilesContext _context;

        public CreateModel(LatestMobilesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mobiles Mobiles { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Mobiles.Add(Mobiles);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
