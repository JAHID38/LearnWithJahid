namespace oj.lc;

public class ConcatenateArrayWithReverse_3925
{
    public int[] ConcatWithReverse(int[] nums)
    {

        int n = nums.Length;
        int[] ans = new int[2 * n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[n - 1 - i];
        }
        return ans;
    }
}
