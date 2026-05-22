namespace oj.lc;

internal class SearchinRotatedSortedArray_33
{
    public int Search(int[] nums, int target)
    {
        // Time complexity constraint: O(log n)
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) >> 1;

            if (nums[mid] == target)
            {
                return mid;
            }

            //left sub-array is sorted:
            if (nums[left] < nums[mid])
            {
                //target is within the left sub-array:
                if (nums[left] <= target && target <=  nums[mid])
                {
                    right = mid - 1;
                }
                //target is not in left sub-array
                //eliminate the left sub-array
                else
                {
                    left = mid + 1;
                }
            }

            //right sub-array is sorted:
            else if (nums[mid] < nums[right])
            {
                //target is within the right sub-array:
                if (nums[mid] <= target && target <= nums[right])
                {
                    left = mid + 1;
                }
                //target is not in right sub-array
                //eliminate the right sub-array
                else
                {
                    right = mid - 1;
                }
            }

            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
