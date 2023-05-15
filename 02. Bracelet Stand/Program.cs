using System;

namespace _02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoneyaDay = double.Parse(Console.ReadLine());
            double salesMoney = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());
            double prezentPrice = double.Parse(Console.ReadLine());

            double totalSaved = ((pocketMoneyaDay + salesMoney) * 5) - expenses;

            if (prezentPrice <= totalSaved)
            {
                Console.WriteLine($"Profit: {totalSaved:f2} BGN, the gift has been purchased.");

            }
            else
            {
                Console.WriteLine($"Insufficient money: {prezentPrice - totalSaved:f2} BGN.");

            }

        }
    }
}
