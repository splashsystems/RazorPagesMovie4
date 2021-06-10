using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie4.Data;
using RazorPagesMovie4.Models;

namespace RazorPagesMovie4.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie4.Data.RazorPagesMovie4Context _context;

        public DetailsModel(RazorPagesMovie4.Data.RazorPagesMovie4Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
