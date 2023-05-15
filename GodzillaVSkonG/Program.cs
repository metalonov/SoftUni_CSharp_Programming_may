using System;

namespace GodzillaVSkonG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double clothesCost = statist * clothesPrice;
            
            if (statist > 150)
            {
                clothesCost -= clothesCost * 0.1;
            }
            double setCost = movieBudget * 0.1;
            double movieCost = setCost + clothesCost;

            if (movieCost > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(movieBudget - movieCost):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - movieCost:f2} leva left.");
            }
        }
    }
}
