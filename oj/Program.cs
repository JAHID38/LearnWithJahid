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
