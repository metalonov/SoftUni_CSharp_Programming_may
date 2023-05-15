using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());  
            string season = Console.ReadLine();
            string location = Console.ReadLine();
            double reward = 0.0;

            if (season == "summer")
            {
                if (location == "Bulgaria")
                {
                    reward = dancers * points;
                    reward -= (reward * 0.05);
                }
                else
                {
                    reward = (dancers * points) + (dancers * points * 0.5);
                    reward -= (reward * 0.1);
                }
            }
            if (season == "winter")
            {
                if (location == "Bulgaria")
                {
                    reward = dancers * points;
                    reward -= (reward * 0.08);
                }
                else
                {
                    reward = (dancers * points) + (dancers * points * 0.5);
                    reward -= (reward * 0.15);
                }
            }
            double dancerReward = (reward - (reward * 0.75)) / dancers;
            Console.WriteLine($"Charity - {reward * 0.75:f2}");
            Console.WriteLine($"Money per dancer - {dancerReward:f2}");
        }
    }
}
