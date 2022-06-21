using Demo_Library.Interface;

namespace Demo_Library.Infra.Invoker;
public class DataCommandInvoker
{
    private ICommand? command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
        Console.WriteLine($"Command {command.GetType()}");
    }

    public void ExecuteCommand()
    {
        command?.Execute();
    }
}
