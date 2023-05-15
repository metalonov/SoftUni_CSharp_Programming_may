using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            string spendSave;
            double money;
            int dayCount = 0;
            int spendingCount = 0;
            while (moneyAvailable < moneyNeeded)
            {
                spendSave = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                dayCount++;
                if (spendSave == "save")
                {
                    moneyAvailable += money;
                    spendingCount = 0;
                }
                else 
                {
                    spendingCount++;
                    if (spendingCount == 5) 
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(dayCount);
                        break;
                    }
                    moneyAvailable -= money;
                    if (moneyAvailable < 0) 
                    {
                        moneyAvailable = 0;
                    }
                }
            }
            if (moneyAvailable >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
        }
    }
}
