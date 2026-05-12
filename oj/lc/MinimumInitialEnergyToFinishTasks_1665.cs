namespace oj.lc;

public class MinimumInitialEnergyToFinishTasks_1665
{
    public int MinimumEffort(int[][] tasks)
    {
        //Sort the array based on 1, 0 indices values diff:
        Array.Sort(tasks, (a, b) =>
        {
            int diff = (b[1] - b[0]).CompareTo(a[1] - a[0]);

            if (diff == 0)
            {
                return b[1].CompareTo(a[1]);
            }

            return diff;
        });

        int sum = tasks[0][1], actual = 0, min = 1, surplus = 0;

        for (int row = 0; row < tasks.Length - 1; row++)
        {
            int balance = tasks[row][min] - tasks[row][actual] + surplus;

            if (tasks[row + 1][min] > balance)
            {
                sum += tasks[row + 1][min] - balance;
                surplus = 0;
            }

            else if (tasks[row + 1][min] < balance)
            {
                surplus = balance - tasks[row + 1][min];
            }

            else
            {
                surplus = 0;
            }
        }

        return sum;
    }
}
