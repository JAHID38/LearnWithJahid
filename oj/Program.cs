// See https://aka.ms/new-console-template for more information
using oj.lc;

Console.WriteLine("Hello, World!");

//int[][] tasks = [[1, 2], [2, 4], [4, 8]];                 //8
//int[][] tasks = [[1, 1], [1, 3]];                 //3
//int[][] tasks = [[1, 2], [1, 7], [2, 3], [5, 9], [2, 2]];   //11
//int[][] tasks = [[2, 4], [2, 2], [1, 1], [4, 5], [3, 9], [3, 3]];   //15

//int r = new MinimumInitialEnergyToFinishTasks_1665().MinimumEffort(tasks);
//Console.WriteLine(r);


/*
 * 2784
 */
//int[] nums = [2, 4, 4, 4];
//Console.WriteLine(new CheckIfArrayIsGood_2784().IsGood(nums));

/*
 * 1306
 */
//int[] arr = [4, 4, 1, 3, 0, 3];
//int start = 2;
int[] arr = [1, 1, 1, 1, 1, 1, 1, 1, 0];
int start = 3;
//int[] arr = [3, 0, 2, 1, 2];
//int start = 2;
Console.WriteLine(new JumpGameIII_1306().CanReach(arr, start));

/*
 * 3925
 */
int[] nums = [1, 2, 3];
Console.WriteLine(new ConcatenateArrayWithReverse_3925().ConcatWithReverse(nums));

/*
 * 2540
 */
int[] nums1 = [3, 8], nums2 = [1, 3, 4, 5, 8, 9];
Console.WriteLine(new MinimumCommonValue_2540().GetCommon(nums1, nums2));

/*
 * 2657
 */
Console.WriteLine("======== 2657 ========");
int[] A = [2, 3, 1], B = [3, 1, 2];
int[] ans = new FindthePrefixCommonArrayofTwoArrays_2657().FindThePrefixCommonArray(A, B);
foreach(int i in ans)
{
    Console.WriteLine(i);
}

/*
 * 33
 */
Console.WriteLine("======== 33 ========");
//int[] nums33 = [4, 5, 6, 7, 0, 1, 2];
//int target = 3;
int[] nums33 = [5, 1, 3];
int target = 5;
Console.WriteLine(new SearchinRotatedSortedArray_33().Search(nums33, target));

/*
 * 3120
 */
Console.WriteLine("======== 3120 ========");
string word = "zaaAbcBCZ";
Console.WriteLine(new CounttheNumberofSpecialCharactersI_3120().NumberOfSpecialChars(word));

/*
 * 2144
 */
Console.WriteLine("======== 2144 ========");
int[] cost = [1,2,3];
Console.WriteLine(new MinimumCostofBuyingCandiesWithDiscount_2144().MinimumCost(cost));
