namespace oj.lc
{
    internal class MaximumTotalSubarrayValueI_3689
    {
        public long MaxTotalValue(int[] nums, int k)
        {
            int max = -1, min = int.MaxValue;

            foreach (int i in nums)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
            }

            return (long)k * (max - min);
        }
    }
}
