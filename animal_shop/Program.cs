using System;

namespace animalFood_shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = 2.5;
            int catFood = 4;
            int dogPacks = int.Parse(Console.ReadLine());
            int catPacks = int.Parse(Console.ReadLine());
            // Calculation
            double totalCost = dogFood * dogPacks + catFood * catPacks;
            Console.WriteLine(totalCost + " lv.");
        }
    }
}
