using System.Windows.Input;

namespace MovieCollectionTrackerApp.Commands;

public class RelayCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    public event EventHandler? CanExecuteChanged; 

    public RelayCommand(Action execute, Func<bool>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
        CanExecuteChanged += delegate { }; 
    }

    public bool CanExecute(object? parameter) 
    {
        return _canExecute == null || _canExecute();
    }

    public void Execute(object? parameter)
    {
        _execute();
    }
}