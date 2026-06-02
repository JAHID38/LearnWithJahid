namespace oj.lc;

internal class EarliestFinishTimeforLandandWaterRidesI_3633
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        int min = int.MaxValue;

        for (int land = 0; land < landStartTime.Length; land++)
        {
            for (int water = 0; water < waterStartTime.Length; water++)
            {
                int landFirst = landStartTime[land] + landDuration[land];
                int waterFirst = waterStartTime[water] + waterDuration[water];

                //land to water:
                min = landFirst < waterStartTime[water] ? Math.Min(min, waterStartTime[water] + waterDuration[water]) : Math.Min(min, landFirst + waterDuration[water]);

                //water to land:
                min = waterFirst < landStartTime[land] ? Math.Min(min, landStartTime[land] + landDuration[land]) : Math.Min(min, waterFirst + landDuration[land]);


                //Debugging:
                Console.WriteLine("{0} -> {1} -> {2}", landStartTime[land], landDuration[land], waterDuration[water]);
                Console.WriteLine("Land -> Water: {0}", landFirst + waterDuration[water]);

                Console.WriteLine("{0} -> {1} -> {2}", waterStartTime[water], waterDuration[water], landDuration[land]);
                Console.WriteLine("Water -> Land: {0}", waterFirst + landDuration[land]);
            }
        }

        return min;
    }
}
