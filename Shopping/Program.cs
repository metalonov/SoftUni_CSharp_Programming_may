using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoAmount = double.Parse(Console.ReadLine());
            double cpuAmount = double.Parse(Console.ReadLine());
            double memAmount = double.Parse(Console.ReadLine());

            double videoCost = videoAmount * 250;
            double cpuCost = videoCost * 0.35;
            double memCost = videoCost * 0.10;
            double hwCost = videoCost + (cpuCost * cpuAmount) + (memCost * memAmount);
            if (videoAmount > cpuAmount)
            {
                hwCost -= hwCost * 0.15;
            }
            if (hwCost <= budget)
            {
                Console.WriteLine($"You have {(budget - hwCost):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - hwCost):f2} leva more!");
            }
            }
    }
}
