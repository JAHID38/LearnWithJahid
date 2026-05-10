
using dsa.dynamicProgramming.addition;
using dsa.dynamicProgramming.fibonacci;

Console.WriteLine("Hello, World!");

//Console.Write("Recursion sum:\t");
int result = new SumOf1toN().RecursionAddition(10);
Console.WriteLine(result);

Console.WriteLine(new NthFibonacci().Fibonacci(35));
Console.WriteLine(FibonacciMemoization.NthFibonacciWithMemoization(6));
