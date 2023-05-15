using System;
using System.Xml.Schema;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            switch (flower)
            {
                case "Roses":
                    price = 5.00;
                    if (quantity > 80)
                    {
                        price -= price * 0.10;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (quantity > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (quantity > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = 3.00;
                    if (quantity < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (quantity < 80)
                    {
                        price += price * 0.20;
                    }
                    break;
            }
            double total = price * quantity;
                if (budget >= total)
                {    
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - total:f2} leva left.");
                }
                else
                {
                Console.WriteLine($"Not enough money, you need {Math.Abs(total - budget):f2} leva more.");
                }
        }
    }
}
