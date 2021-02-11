using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGallery.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieGalleryContext(serviceProvider.GetRequiredService<DbContextOptions<MovieGalleryContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Inglourious Basterds",
                        Genre = "Adventure",
                        Description = "In Nazi-occupied France during World War II, a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.",
                        ReleaseDate = DateTime.Parse("19 August 2009"),
                        ImageName = "1efab829ec3ca59984a7cc139e924529.jpg",
                        IMDBLinkUrl = "https://www.imdb.com/title/tt0361748/?ref_=nv_sr_srsg_0"
                    },
                    new Movie
                    {
                        Title = "The Matrix",
                        Genre = "Sci-Fi",
                        Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                        ReleaseDate = DateTime.Parse("11 June 1999"),
                        ImageName = "the-matrix.jpg",
                        IMDBLinkUrl = "https://www.imdb.com/title/tt0133093/?ref_=fn_al_tt_1"
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        Genre = "Crime",
                        Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                        ReleaseDate = DateTime.Parse("24 August 1972"),
                        ImageName = "the-godfather.jpg",
                        IMDBLinkUrl = "https://www.imdb.com/title/tt0068646/?ref_=fn_al_tt_3"
                    },
                    new Movie
                    {
                        Title = "The Big Short",
                        Genre = "Biography",
                        Description = "In 2006-2007 a group of investors bet against the US mortgage market. In their research they discover how flawed and corrupt the market is.",
                        ReleaseDate = DateTime.Parse("22 January 2016"),
                        ImageName = "MV5BNDc4MThhN2EtZjMzNC00ZDJmLThiZTgtNThlY2UxZWMzNjdkXkEyXkFqcGdeQXVyNDk3NzU2.jpg",
                        IMDBLinkUrl = "https://www.imdb.com/title/tt1596363/?ref_=fn_al_tt_1"
                    },
                    new Movie
                    {
                        Title = "Lassie",
                        Genre = "Family",
                        Description = "When a family of 4 moves from Baltimore to a farm in rural Virginia, they adopt an abandoned collie. The dog becomes the son's companion and protector, helping him adapt to rural life.",
                        ReleaseDate = DateTime.Parse("7 April 1995"),
                        ImageName = "lassie.jpg",
                        IMDBLinkUrl = "https://www.imdb.com/title/tt0110305/?ref_=fn_al_tt_2"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
