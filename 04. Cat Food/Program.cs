using System;

namespace _04._Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodGrams = 0.0;
            int catAmt = int.Parse(Console.ReadLine());
            int smallCatCounter = 0;
            int mediumCatCounter = 0;
            int hugeCatCounter = 0;
            double foodPrice = 0.0;
            double allFood = 0;

            //1 кг храна = 12.45 лева. 1kg = 1000gr!!!

            for (int i = 0; i < catAmt; i++)
            {
                foodGrams = double.Parse(Console.ReadLine());
                allFood += foodGrams;
                if (foodGrams >= 100 && foodGrams < 200) //small cats
                {
                    smallCatCounter++;
                }
                else if (foodGrams >= 200 && foodGrams < 300) //medium cats
                {
                    mediumCatCounter++;
                }
                else if (foodGrams >= 300 && foodGrams < 400) //huuuge cats
                {
                    hugeCatCounter++;
                }
            }
            allFood /= 1000;

            Console.WriteLine($"Group 1: {smallCatCounter} cats.");
            Console.WriteLine($"Group 2: {mediumCatCounter} cats.");
            Console.WriteLine($"Group 3: {hugeCatCounter} cats.");
            Console.WriteLine($"Price for food per day: {allFood * 12.45:f2} lv.");
        }
    }
}
