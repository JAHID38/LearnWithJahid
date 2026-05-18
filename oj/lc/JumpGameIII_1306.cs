namespace oj.lc;

public class JumpGameIII_1306
{
    public bool CanReach(int[] arr, int start)
    {

        if (start < 0 || start > arr.Length - 1 || arr[start] == -1)
            return false;

        if (arr[start] == 0)
            return true;

        int jump = arr[start];

        arr[start] = -1;

        return CanReach(arr, start + jump) || CanReach(arr, start - jump);

    }
}
