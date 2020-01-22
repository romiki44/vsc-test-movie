using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebRazor1.Data;
using WebRazor1.Models;

namespace WebRazor1
{
    public class IndexModel : PageModel
    {
        private readonly WebRazor1.Data.WebAppContext _context;

        public IndexModel(WebRazor1.Data.WebAppContext context)
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
