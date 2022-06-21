using Demo_Library.Data;
using Demo_Library.Infra.Commands;
using Demo_Library.Infra.Invoker;
using static System.Console;


DataReceiver receiver = new();
DataCommandInvoker commandInvoker = new();

commandInvoker.SetCommand(new UpsertCommand("key1", "item1", receiver));
commandInvoker.ExecuteCommand();

commandInvoker.SetCommand(new DeleteCommand("key1", receiver));
commandInvoker.ExecuteCommand();

ReadKey();

