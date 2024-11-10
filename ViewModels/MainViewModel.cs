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

    public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
    public Movie SelectedMovie { get; set; } = new Movie();

    public ICommand AddMovieCommand { get; }
    public ICommand DeleteMovieCommand { get; }
    
    public ICommand EditMovieCommand { get; }

    public MainViewModel(IMovieService movieService)
    {
        _movieService = movieService;

        AddMovieCommand = new RelayCommand(AddMovie);
        DeleteMovieCommand = new RelayCommand(DeleteMovie);
        EditMovieCommand = new RelayCommand(OpenEditMovieWindow, CanEditMovie);
        
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
        // Tworzymy nowy obiekt `Movie` z domyślnymi wartościami
        var newMovie = new Movie
        {
            Title = "New Movie", // Możesz tu ustawić domyślne wartości lub puste pola
            Genre = "Genre",
            Director = "Director",
            ReleaseYear = DateTime.Now.Year,
            Rating = 0.0
        };

        _movieService.AddMovie(newMovie); // Dodajemy nowy film do serwisu
        LoadMovies(); // Odświeżamy listę filmów
    }

    private void UpdateMovie()
    {
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
            DataContext = SelectedMovie // Ustawienie wybranego filmu jako DataContext
        };

        if (editWindow.ShowDialog() == true) // Jeśli użytkownik zapisze zmiany
        {
            SaveMovie(); // Zapisz zmiany do bazy danych lub listy
        }
    }

    private void SaveMovie()
    {
        if (SelectedMovie != null)
        {
            _movieService.UpdateMovie(SelectedMovie);
        }
    }

}