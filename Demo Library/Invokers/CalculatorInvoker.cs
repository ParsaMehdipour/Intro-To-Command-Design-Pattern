using Demo_Library.Interfaces;

namespace Demo_Library.Invokers;

/// <summary>
/// The Invoker is associated with one or several commands. It sends a
/// request to the command.
/// </summary>
public class CalculatorInvoker
{
    private List<ICommand> commands = new List<ICommand>();
    private int current = -1;

    public void Compute(ICommand command)
    {
        command.Execute();
        commands.Add(command);
        current++;
    }

    public void Undo()
    {
        if (current >= 0)
        {
            commands[current].Undo();
            current--;
        }
    }

    public void Redo()
    {
        if (current < commands.Count - 1)
        {
            Console.WriteLine("Redoing ...");
            current++;
            commands[current].Execute();
        }
    }
}
