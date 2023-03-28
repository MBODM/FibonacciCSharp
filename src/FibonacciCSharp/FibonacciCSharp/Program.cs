using FibonacciCSharp;
using FibonacciLib;

var user = new FibonacciUser(new Fibonacci());

Console.WriteLine("Running Fibonacci now...");
Console.WriteLine();

var result = user.TestRun();
result.ToList().ForEach(i => Console.Write($"{i} "));
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Have a nice day.");
