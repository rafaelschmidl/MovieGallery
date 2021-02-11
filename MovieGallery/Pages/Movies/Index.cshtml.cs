using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieGallery.Data;
using MovieGallery.Model;

namespace MovieGallery.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieGallery.Data.MovieGalleryContext _context;

        public IndexModel(MovieGallery.Data.MovieGalleryContext context)
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
