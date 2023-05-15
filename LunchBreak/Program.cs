using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfShow = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());

            double lunchTimeSeries = (double)lunchTime * 5/ 8;

                if (lunchTimeSeries >= seriesTime)
                {
                Console.WriteLine($"You have enough time to watch {nameOfShow} and left with {Math.Ceiling(lunchTimeSeries - seriesTime)} minutes free time.");
                }
                else
                {
                Console.WriteLine($"You don't have enough time to watch {nameOfShow}, you need {Math.Ceiling(seriesTime - lunchTimeSeries)} more minutes.");
                }
        }
    }
}
