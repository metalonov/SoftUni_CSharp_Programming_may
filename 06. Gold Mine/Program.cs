using System;

namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expectedMedianYield = 0.0;
            int yieldPerDay = 0;
            double totalYieldPerLocation = 0.0;
            int days = 0;
            for (int locations = int.Parse(Console.ReadLine()); locations > 0; locations--)
            {
                expectedMedianYield = double.Parse(Console.ReadLine());
                yieldPerDay = 0;
                totalYieldPerLocation = 0;
                days = 0;
                for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
                {
                    days++;
                    yieldPerDay = int.Parse(Console.ReadLine());
                    totalYieldPerLocation += (double)yieldPerDay;
                }
                totalYieldPerLocation /= days;

                if (totalYieldPerLocation >= expectedMedianYield)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalYieldPerLocation:f2}.");
                }
                if (totalYieldPerLocation < expectedMedianYield)
                {
                    Console.WriteLine($"You need {Math.Abs(totalYieldPerLocation - expectedMedianYield):f2} gold.");
                }

            }

        }
    }
}
