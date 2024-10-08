namespace Demo_Library;

/// <summary>
/// The Receiver classes contain some important business logic. They know how
/// to perform all kinds of operations, associated with carrying out a
/// request. In fact, any class may serve as a Receiver
/// </summary>
public class Calculator
{
    private int currentValue;

    public void Add(int value)
    {
        Console.WriteLine($"Add {value} to the current value of {currentValue}");
        currentValue += value;
    }

    public void Subtract(int value)
    {
        Console.WriteLine($"Subtract the current value of {currentValue} by {value}");
        currentValue -= value;
    }

    public int GetValue()
    {
        return currentValue;
    }
}
