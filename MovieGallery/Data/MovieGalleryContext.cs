using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieGallery.Model;

namespace MovieGallery.Data
{
    public class MovieGalleryContext : DbContext
    {
        public MovieGalleryContext (DbContextOptions<MovieGalleryContext> options)
            : base(options)
        {
        }

        public DbSet<MovieGallery.Model.Movie> Movie { get; set; }
    }
}
