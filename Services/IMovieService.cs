using MovieCollectionTrackerApp.Models;

namespace MovieCollectionTrackerApp.Services;

public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie GetMovieById(int id);
    void AddMovie(Movie movie);
    void UpdateMovie(Movie movie);
    void DeleteMovie(int id);
}