using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Task1.Data;
using Task1.Models;

namespace Task1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Task1.Data.Task1Context _context;

        public IndexModel(Task1.Data.Task1Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
