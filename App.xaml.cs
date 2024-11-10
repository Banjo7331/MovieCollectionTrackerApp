using System.Windows;
using MovieCollectionTrackerApp.Services;
using MovieCollectionTrackerApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace MovieCollectionTrackerApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        _serviceProvider = serviceCollection.BuildServiceProvider();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        // Rejestracja serwisów i widoków jako singletony
        services.AddSingleton<IMovieService, MovieService>();
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<MainWindow>(); // Dodajemy MainWindow jako singleton
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        try
        {
            MessageBox.Show("App is starting..."); // Dodano log

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();

            MessageBox.Show("Showing MainWindow..."); // Dodano log

            mainWindow.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Wystąpił błąd: {ex.Message}\n{ex.StackTrace}", "Błąd aplikacji", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown();
        }
    }
}

