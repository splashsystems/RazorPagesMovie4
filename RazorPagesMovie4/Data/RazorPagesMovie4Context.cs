using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie4.Models;

namespace RazorPagesMovie4.Data
{
    public class RazorPagesMovie4Context : DbContext
    {
        public RazorPagesMovie4Context (DbContextOptions<RazorPagesMovie4Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie4.Models.Movie> Movie { get; set; }
    }
}
