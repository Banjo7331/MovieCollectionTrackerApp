using System.Collections.ObjectModel;
using System.Windows.Input;
using MovieCollectionTrackerApp.Commands;
using MovieCollectionTrackerApp.Models;
using MovieCollectionTrackerApp.Services;
using MovieCollectionTrackerApp.Views;

namespace MovieCollectionTrackerApp.ViewModels;

public class MainViewModel : BaseViewModel
{
    private readonly IMovieService _movieService;
    public static IEnumerable<MovieCategory> Categories => Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>();
    public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
    public Movie SelectedMovie { get; set; } = new Movie();

    public ICommand AddMovieCommand { get; }
    public ICommand DeleteMovieCommand { get; }
    
    public ICommand EditMovieCommand { get; }
    
    public ICommand OpenStatisticsWindowCommand { get; }

    public MainViewModel(IMovieService movieService)
    {
        _movieService = movieService;

        AddMovieCommand = new RelayCommand(AddMovie);
        DeleteMovieCommand = new RelayCommand(DeleteMovie);
        EditMovieCommand = new RelayCommand(OpenEditMovieWindow, CanEditMovie);
        OpenStatisticsWindowCommand = new RelayCommand(OpenStatisticsWindow);
        
        LoadMovies();
    }

    private void LoadMovies()
    {
        Movies.Clear();
        foreach (var movie in _movieService.GetAllMovies())
        {
            Movies.Add(movie);
        }
    }

    private void AddMovie()
    {
        if (SelectedMovie == null)
        {
            SelectedMovie = new Movie
            {
                Title = "Default Title",
                Category = MovieCategory.Default, 
                Director = "Default Director",
                ReleaseYear = DateTime.Now.Year,
                Rating = 0.0
            };
        }

        var newMovie = new Movie
        {
            Title = string.IsNullOrWhiteSpace(SelectedMovie.Title) ? "Default Title" : SelectedMovie.Title,
            Category = SelectedMovie.Category != null ? SelectedMovie.Category : MovieCategory.Default,
            Director = string.IsNullOrWhiteSpace(SelectedMovie.Director) ? "Default Director" : SelectedMovie.Director,
            ReleaseYear = SelectedMovie.ReleaseYear == 0 ? DateTime.Now.Year : SelectedMovie.ReleaseYear,
            Rating = SelectedMovie.Rating
        };

        _movieService.AddMovie(newMovie);

        LoadMovies();
    }

    private void UpdateMovie()
    {
        Console.WriteLine($"Selected category: {SelectedMovie.Category}");
        _movieService.UpdateMovie(SelectedMovie);
        LoadMovies();
    }

    private void DeleteMovie()
    {
        if (SelectedMovie != null)
        {
            _movieService.DeleteMovie(SelectedMovie.Id);
            LoadMovies();
        }
    }
    private bool CanEditMovie()
    {
        return SelectedMovie != null;
    }
    private void OpenEditMovieWindow()
    {
        if (SelectedMovie == null)
            return;

        var editWindow = new EditMovieWindow
        {
            DataContext = SelectedMovie 
        };

        if (editWindow.ShowDialog() == true) 
        {
            SaveMovie(); 
        }
    }
    
    private void OpenStatisticsWindow()
    {
        var statisticsViewModel = new StatisticsViewModel(Movies);
        var statsWindow = new StatisticWindow(statisticsViewModel);
        statsWindow.ShowDialog();
    }

    private void SaveMovie()
    {
        if (SelectedMovie != null)
        {
            _movieService.UpdateMovie(SelectedMovie);
        }
    }

}