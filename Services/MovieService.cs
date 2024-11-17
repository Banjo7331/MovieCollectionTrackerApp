using MovieCollectionTrackerApp.Data;
using MovieCollectionTrackerApp.Models;

namespace MovieCollectionTrackerApp.Services;

public class MovieService : IMovieService
{
    private readonly MovieDbContext _context;
    
    public MovieService(MovieDbContext context)
    {
        _context = context;
    }
    public List<Movie> GetAllMovies() => _context.Movies.ToList();

    public Movie GetMovieById(int id) => _context.Movies.FirstOrDefault(m => m.Id == id);

    public void AddMovie(Movie movie)
    {
        Console.WriteLine($"Adding Movie: {movie.Title}, Id: {movie.Id} {movie.Category}");
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public void UpdateMovie(Movie movie)
    {
        var existingMovie = GetMovieById(movie.Id);
        if (existingMovie != null)
        {
            existingMovie.Title = movie.Title;
            existingMovie.Category = movie.Category;
            existingMovie.Director = movie.Director;
            existingMovie.ReleaseYear = movie.ReleaseYear;
            existingMovie.Rating = movie.Rating;
            _context.SaveChanges();
        }
    }

    public void DeleteMovie(int id)
    {
        var movie = GetMovieById(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}