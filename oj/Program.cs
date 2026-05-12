// See https://aka.ms/new-console-template for more information
using oj.lc;

Console.WriteLine("Hello, World!");

//int[][] tasks = [[1, 2], [2, 4], [4, 8]];                 //8
//int[][] tasks = [[1, 1], [1, 3]];                 //3
//int[][] tasks = [[1, 2], [1, 7], [2, 3], [5, 9], [2, 2]];   //11
int[][] tasks = [[2, 4], [2, 2], [1, 1], [4, 5], [3, 9], [3, 3]];   //15

int r = new MinimumInitialEnergyToFinishTasks_1665().MinimumEffort(tasks);
Console.WriteLine(r);
