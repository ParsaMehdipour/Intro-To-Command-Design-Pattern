using Demo_Library.Data;
using Demo_Library.Interface;

namespace Demo_Library.Infra;
public abstract class Command : ICommand
{
    protected DataReceiver receiver { get; set; }
    public Command(DataReceiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();

}
