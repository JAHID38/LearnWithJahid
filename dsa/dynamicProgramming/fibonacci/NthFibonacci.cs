using System.Timers;

namespace dsa.dynamicProgramming.fibonacci;

internal class NthFibonacci
{
    public int Fibonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
