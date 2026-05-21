namespace oj.lc;

public class FindtheLengthoftheLongestCommonPrefix_3043
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = [];
        HashSet<int> set2 = [];

        int maxVal = 0;

        foreach (int num in arr1)
        {
            int n = num;

            while (n > 0)
            {
                set1.Add(n);
                n /= 10;
            }
        }        

        foreach (int num in arr2)
        {
            int n = num;

            while (n > 0)
            {
                set2.Add(n);
                
                if (set1.Contains(n))
                {
                    maxVal = Math.Max(maxVal, n);
                }

                n /= 10;
            }
        }

        return maxVal == 0 ? 0 : (int)Math.Floor(Math.Log10(maxVal)) + 1;
    }
}
