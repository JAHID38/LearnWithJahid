namespace oj.lc;

internal class CounttheNumberofSpecialCharactersI_3120
{
    public int NumberOfSpecialChars(string word)
    {
        int count = 0;
        int[] freq = new int[58];       //A-Za-z : 52 + 6 (91-96)
        
        foreach(char ch in word)
        {
            int index =  ch - 'A';
            freq[index] = freq[index] + 1;
        }

        for (int i = 0; i < 26; i++)
        {
            if (freq[i] > 0 && freq[i + 32] > 0)
                count++;
        }

        return count;
    }
}
