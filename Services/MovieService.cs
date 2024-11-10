using MovieCollectionTrackerApp.Models;

namespace MovieCollectionTrackerApp.Services;

public class MovieService : IMovieService
{
    private List<Movie> _movies = new List<Movie>();

    public List<Movie> GetAllMovies() => _movies;

    public Movie GetMovieById(int id) => _movies.FirstOrDefault(m => m.Id == id);

    public void AddMovie(Movie movie)
    {
        if (movie != null)
        {
            movie.Id = _movies.Count + 1; // Automatyczne przypisanie ID
            _movies.Add(movie);
        }
    }

    public void UpdateMovie(Movie movie)
    {
        var existingMovie = GetMovieById(movie.Id);
        if (existingMovie != null)
        {
            existingMovie.Title = movie.Title;
            existingMovie.Genre = movie.Genre;
            existingMovie.Director = movie.Director;
            existingMovie.ReleaseYear = movie.ReleaseYear;
            existingMovie.Rating = movie.Rating;
        }
    }

    public void DeleteMovie(int id)
    {
        var movie = GetMovieById(id);
        if (movie != null)
            _movies.Remove(movie);
    }
}