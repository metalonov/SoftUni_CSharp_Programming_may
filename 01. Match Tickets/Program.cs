using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string vipNormal = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            if (vipNormal == "VIP") 
            {
                if (people >= 1 && people <= 4) 
                {
                    budget -= budget * 0.75; //От 1 до 4 – 75% от бюджета.
                }
                if (people >= 5 && people <= 9)
                {
                    budget -= budget * 0.6; //От 5 до 9 – 60% от бюджета.
                }
                if (people >= 10 && people <= 24)
                {
                    budget -= budget * 0.5; //От 10 до 24 – 50% от бюджета.
                }
                if (people >= 25 && people <= 49)
                {
                    budget -= budget * 0.4; //От 25 до 49 – 40% от бюджета.
                }
                if (people > 50) 
                {
                    budget -= budget * 0.25; //50 или повече – 25% от бюджета.
                }
                if (budget <= people * 499.99)
                {
                    Console.WriteLine($"Not enough money! You need {(double)people * 499.99 - budget:f2} leva.");
                }
                else 
                {
                    Console.WriteLine($"Yes! You have {Math.Abs((double)people *499.99 - budget):f2} leva left.");
                }
            }
            else 
            {
                if (people >= 1 && people <= 4)
                {
                    budget -= budget * 0.75; //От 1 до 4 – 75% от бюджета.
                }
                if (people >= 5 && people <= 9)
                {
                    budget -= budget * 0.6; //От 5 до 9 – 60% от бюджета.
                }
                if (people >= 10 && people <= 24)
                {
                    budget -= budget * 0.5; //От 10 до 24 – 50% от бюджета.
                }
                if (people >= 25 && people <= 49)
                {
                    budget -= budget * 0.4; //От 25 до 49 – 40% от бюджета.
                }
                if (people > 50)
                {
                    budget -= budget * 0.25; //50 или повече – 25% от бюджета.
                }
                if (budget <= people * 249.99)
                {
                    Console.WriteLine($"Not enough money! You need {(double)people * 249.99 - budget:f2} leva.");
                }
                else
                {
                    Console.WriteLine($"Yes! You have {Math.Abs((double)people * 249.99 - budget):f2} leva left.");
                }
            }
        }
    }
}
