namespace oj.lc;

public class FindthePrefixCommonArrayofTwoArrays_2657
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int[] ans = new int[A.Length];
        int[] freq = new int[A.Length + 1];

        int count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            freq[A[i]]++;
            freq[B[i]]++;

            if (freq[A[i]] > 1) count++;
            if (freq[B[i]] > 1) count++;

            if (A[i] == B[i]) count--;

            ans[i] = count;
        }

        return ans;
    }
}
