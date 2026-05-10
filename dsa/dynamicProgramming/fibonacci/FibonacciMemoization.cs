namespace dsa.dynamicProgramming.fibonacci;

internal class FibonacciMemoization
{
    public static int NthFibonacciWithMemoization(int n)
    {
        int[] memo = new int[n+1];

        for (int i = 0; i <= n; i++)
        {
            memo[i] = -1;
        }

        return Fibonacci(n, memo);
    }

    private static int Fibonacci(int n, int[] memo, int index = 0)
    {
        if (n <= 1) return n;

        if (memo[n] != -1)
            return memo[n];

        memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);
        
        return memo[n];
    }
}
