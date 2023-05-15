using System;

namespace _05._Puppy_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine());
            string input;
            int currentFood = 0;
            foodBought *= 1000;

            while ((input = Console.ReadLine()) != "Adopted")
            {
                currentFood = int.Parse(input);
                foodBought -= currentFood;
                if (currentFood <= 0)
                {
                    break;
                }

            }
            if (foodBought >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodBought} grams.");
            }
            else if (foodBought < 0)
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodBought)} grams more.");
            }

        }
    }
}
