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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie4.Data.RazorPagesMovie4Context _context;

        public IndexModel(RazorPagesMovie4.Data.RazorPagesMovie4Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
