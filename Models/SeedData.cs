using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcmovieContext(
           serviceProvider.GetRequiredService<
               DbContextOptions<MvcmovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("2022-01-23"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Jungle book ",
                    ReleaseDate = DateTime.Parse("2024-05-14"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Minions",
                    ReleaseDate = DateTime.Parse("2023-03-23"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "3 idiots",
                    ReleaseDate = DateTime.Parse("2017-06-23"),
                    Genre = "Western",
                    Price = 15.99M,
                    Rating = "R",
                },
                new Movie
                {
                    Title = "Tom and Jerry",
                    ReleaseDate = DateTime.Parse("2019-06-30"),
                    Genre = "Cartoon",
                    Price = 15.99M,
                    Rating = "R",
                }
            );
            context.SaveChanges();
        }
    }
}
