using Microsoft.EntityFrameworkCore;
using MovieCollectionTrackerApp.Models;

namespace MovieCollectionTrackerApp.Data;

public class MovieDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }
}