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
    public class DetailsModel : PageModel
    {
        private readonly LatestMobilesContext _context;

        public DetailsModel(LatestMobilesContext context)
        {
            _context = context;
        }

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
    }
}
