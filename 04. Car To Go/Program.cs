using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine()); //Първи ред – Бюджет – реално число в интервала [10.00...10000.00]
            string season = Console.ReadLine(); //Втори ред –  Сезон – текст "Summer" или "Winter"
            string car;
            string typeClass;
            double carCost = 0;

            //calculation

            if (season == "Summer") //summer
            {
                if (budget <= 100) //При бюджет по-малък или равен от 100лв.:
                {
                    car = "Cabrio";
                    typeClass = "Economy class";
                    carCost = budget - budget * 0.35;
                }
                else if (budget <= 500) //При бюджет по-голям от 100лв.и по-малък или равен от 500лв.:
                {
                    car = "Cabrio";
                    typeClass = "Compact class";
                    carCost = budget - budget * 0.45;
                }
                else //(budget > 500) При бюджет по-голям от 500лв.:
                {
                    car = "Jeep";
                    typeClass = "Luxury class";
                    carCost = budget - budget * 0.9;
                }

            }
            else //Winter
            {
                if (budget <= 100) //При бюджет по-малък или равен от 100лв.:
                {
                    car = "Jeep";
                    typeClass = "Economy class";
                    carCost = budget - budget * 0.65;
                }
                else if (budget <= 500) //При бюджет по-голям от 100лв.и по-малък или равен от 500лв.:
                {
                    car = "Jeep";
                    typeClass = "Compact class";
                    carCost = budget - budget * 0.80;
                }
                else //(budget > 500) При бюджет по-голям от 500лв.:
                {
                    car = "Jeep";
                    typeClass = "Luxury class";
                    carCost = budget - budget * 0.9;
                }
            }

            //output
            Console.WriteLine($"{typeClass}");
            Console.WriteLine($"{car} - {budget - carCost:f2}");

        }
    }
}
