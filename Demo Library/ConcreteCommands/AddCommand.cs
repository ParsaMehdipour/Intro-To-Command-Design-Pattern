using Demo_Library.Interfaces;

namespace Demo_Library.ConcreteCommands;

/// <summary>
/// Some commands can implement simple operations on their own.
/// However, some commands can delegate more complex operations to other
/// objects, called "receivers."
/// </summary>
public class AddCommand : ICommand
{
    private Calculator calculator; // receiver
    private int operand;

    public AddCommand(Calculator calculator, int operand)
    {
        this.calculator = calculator;
        this.operand = operand;
    }

    public void Execute()
    {
        calculator.Add(operand);
    }

    public void Undo()
    {
        Console.WriteLine("Undoing ...");
        calculator.Subtract(operand);
    }
}
