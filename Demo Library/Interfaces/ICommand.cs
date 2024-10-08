namespace Demo_Library.Interfaces;

/// <summary>
/// The Command interface declares a method for executing a command.
/// </summary>
public interface ICommand
{
    void Execute();
    void Undo();
}
