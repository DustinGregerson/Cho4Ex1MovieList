using Microsoft.EntityFrameworkCore;
namespace Cho4Ex1MovieList.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            :base(options) { }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
            new Movie
             {
                MovieId = 1,
                Name = "Casablanca",
                Year = 1942,
                rating = 5
             },
             new Movie
             {
             MovieId = 2,
             Name = "Wonder Woman",
             Year = 2017,
             rating = 3
             },
             new Movie
             {
             MovieId = 3,
             Name = "Moonstruck",
             Year = 1988,
             rating = 4
             }
            );
        }
    }
}
