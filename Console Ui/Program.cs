using Demo_Library;
using Demo_Library.ConcreteCommands;
using Demo_Library.Invokers;

Calculator calculator = new Calculator();
CalculatorInvoker invoker = new CalculatorInvoker();

// Perform calculations
invoker.Compute(new AddCommand(calculator, 5));
Console.WriteLine($"Current Value: {calculator.GetValue()}"); // Output: 5

invoker.Compute(new SubtractCommand(calculator, 3));
Console.WriteLine($"Current Value: {calculator.GetValue()}"); // Output: 2

invoker.Compute(new AddCommand(calculator, 10));
Console.WriteLine($"Current Value: {calculator.GetValue()}"); // Output: 12

// Undo operations
invoker.Undo();
Console.WriteLine($"After Undo: {calculator.GetValue()}"); // Output: 2

invoker.Undo();
Console.WriteLine($"After Undo: {calculator.GetValue()}"); // Output: 5

// Redo operation
invoker.Redo();
Console.WriteLine($"After Redo: {calculator.GetValue()}"); // Output: 2