using System.Windows;
using System.Windows.Controls;
using MovieCollectionTrackerApp.ViewModels;

namespace MovieCollectionTrackerApp.Views;

public partial class StatisticWindow : Window
{
    public StatisticWindow(StatisticsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel; // Ustawienie DataContext na przekazany ViewModel
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}