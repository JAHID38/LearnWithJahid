namespace oj.lc;

internal class MinimumCostofBuyingCandiesWithDiscount_2144
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);

        int sum = 0;

        for (int i = cost.Length - 1; i >= 0; i -= 3)
        {
            sum += cost[i];

            if (i - 1 >= 0) sum += cost[i - 1];
        }

        return sum;
    }
}
