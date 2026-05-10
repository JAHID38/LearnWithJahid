namespace dsa.dynamicProgramming.addition;

internal class SumOf1toN
{
    public int RecursionAddition(int value)
    {
        Console.WriteLine(value);

        if (value == 0)
            return 0;

        return value + RecursionAddition(value - 1); 
    }
}
