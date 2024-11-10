using System.Windows.Input;

namespace MovieCollectionTrackerApp.Commands;

public class RelayCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    public event EventHandler? CanExecuteChanged; // Obsługa nullability

    public RelayCommand(Action execute, Func<bool>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
        CanExecuteChanged += delegate { }; // Uniknięcie null dla zdarzenia
    }

    public bool CanExecute(object? parameter) // Umożliwienie null dla parametru
    {
        return _canExecute == null || _canExecute();
    }

    public void Execute(object? parameter)
    {
        _execute();
    }
}