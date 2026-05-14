namespace oj.lc;

public class CheckIfArrayIsGood_2784
{
    public bool IsGood(int[] nums)
    {
        Array.Sort(nums);
        int i;

        for (i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != i + 1)
                return false;
        }

        return i == nums[nums.Length - 1];
    }
}
