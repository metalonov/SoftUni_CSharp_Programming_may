using System;

namespace _05._Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            int budget;

            string input = Console.ReadLine();

            while (input != "End")
            {
                destination = input;
                budget = int.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    budget -= int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
            }

        }
    }
}
