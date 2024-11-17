namespace MovieCollectionTrackerApp.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty; 
    public string Director { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }
    public MovieCategory Category { get; set; }
}