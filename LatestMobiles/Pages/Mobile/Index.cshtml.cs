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
    public class IndexModel : PageModel
    {
        private readonly LatestMobilesContext _context;

        public IndexModel(LatestMobilesContext context)
        {
            _context = context;
        }

        public IList<Mobiles> Mobiles { get;set; }

        public async Task OnGetAsync()
        {
            Mobiles = await _context.Mobiles.ToListAsync();
        }
    }
}
