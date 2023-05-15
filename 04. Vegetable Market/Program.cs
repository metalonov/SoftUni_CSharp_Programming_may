using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegWeight = double.Parse(Console.ReadLine());
            double fruitWeight = double.Parse(Console.ReadLine());
            double profit = ((vegPrice * vegWeight) + (fruitPrice * fruitWeight)) / 1.94;

            Console.WriteLine($"{profit:f2}");
        }
    }
}
