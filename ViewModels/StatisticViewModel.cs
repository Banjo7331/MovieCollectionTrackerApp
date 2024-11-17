using MovieCollectionTrackerApp.Models;

namespace MovieCollectionTrackerApp.ViewModels;

public class StatisticsViewModel
{
    public int TotalMovies { get; set; }
    public double AverageRating { get; set; }
    public Dictionary<string, int> MoviesByCategory { get; set; }

    public StatisticsViewModel(IEnumerable<Movie> movies)
    {
        TotalMovies = movies.Count();
        AverageRating = movies.Average(m => m.Rating);

        MoviesByCategory = movies
            .GroupBy(m => m.Category.ToString())
            .ToDictionary(g => g.Key, g => g.Count());
    }
}