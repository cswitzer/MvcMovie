using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M,
                        ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTd3wINEKXJImkeEqBVSBTH5iyuL9ryEdbX15y5Fap9xKdMeWW0"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 8.99M,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/2f/Ghostbusters_%281984%29_theatrical_poster.png"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 9.99M,
                        ImageUrl = "https://images.moviesanywhere.com/91d9a31794d051d6317057de6349bcb3/5e40389a-cd93-47cf-8f45-a90fc6486f99.jpg"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "PG-13",
                        Price = 3.99M,
                        ImageUrl = "https://www.themoviedb.org/t/p/w500/4gI4KKmoi0d3yfsF71YU3S0I5t8.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
