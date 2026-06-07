namespace oj.lc
{
    internal class LeftandRightSumDifferences_2574
    {
        public int[] LeftRightDifference(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int lSum = 0, rSum = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                rSum += nums[i];
            }

            ans[0] = rSum;

            for (int i = 1; i < nums.Length; i++)
            {
                lSum += nums[i - 1];
                rSum -= nums[i];

                ans[i] = Math.Abs(lSum - rSum);
            }

            return ans;
        }
    }
}
