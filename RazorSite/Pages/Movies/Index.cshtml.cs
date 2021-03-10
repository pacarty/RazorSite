using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSite.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;
        public IList<Movie> MovieList { get; set; }

        public IndexModel(DataContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            MovieList = await _context.Movies.ToListAsync();
        }
    }
}
