using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int donationsTarget = int.Parse(Console.ReadLine());
            int collectedDonations = 0;
            string input;
            int payCounter = 0;
            int cardCounter = 0;
            int cashCounter = 0;
            int cardAmount = 0;
            int cashAmount = 0;
            
            while ((input = Console.ReadLine()) != "End") //редуват: плащане в брой и плащане с карта
            {
                payCounter++;
                if (payCounter % 2 == 0) //card pay
                {
                    if (int.Parse(input) < 10) //Ако продуктът е на цена под 10лв., за него не може да се плати с кредитна карта
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    else
                    {
                        collectedDonations += int.Parse(input);
                        Console.WriteLine("Product sold!");
                        cardCounter++;
                        cardAmount+= int.Parse(input);
                        if (collectedDonations >= donationsTarget)
                        {
                            break;
                        }
                        continue;
                    }
                }
                else //cash pay
                {
                    if (int.Parse(input) > 100) //Ако продуктът надвишава 100лв., за него не може да се плати в брой
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    else
                    {
                        collectedDonations += int.Parse(input);
                        Console.WriteLine("Product sold!");
                        cashCounter++;
                        cashAmount += int.Parse(input);
                        if (collectedDonations >= donationsTarget)
                        {
                            break;
                        }
                    }
                }
            }
            if (collectedDonations >= donationsTarget)
            {
                Console.WriteLine($"Average CS: {((double)cashAmount / cashCounter):f2}");
                Console.WriteLine($"Average CC: {((double)cardAmount / cardCounter):f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
