using Microsoft.EntityFrameworkCore;
using TheMovieApi.Models;

namespace TheMovieApi.Database
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
