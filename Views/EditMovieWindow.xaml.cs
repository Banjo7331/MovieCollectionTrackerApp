using System.Windows;

namespace MovieCollectionTrackerApp.Views;

public partial class EditMovieWindow : Window
{
    public EditMovieWindow()
    {
        InitializeComponent();
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true; // Ustawienie DialogResult na true, aby potwierdzić zapis
        Close();
    }
}