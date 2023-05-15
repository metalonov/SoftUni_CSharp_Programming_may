using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation;
            string location;
            double vacationCost = 0;

            if (budget <= 1000)
            {
                accomodation = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    vacationCost = budget - budget * 0.65;
                }
                else //winter
                {
                    location = "Morocco";
                    vacationCost = budget - budget * 0.45;
                }
            }
            else if (budget <= 3000) //по-голям от 1000лв. и по-малък или равен от 3000лв
            {
                accomodation = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    vacationCost = budget - budget * 0.80;
                }
                else //winter
                {
                    location = "Morocco";
                    vacationCost = budget - budget * 0.60;
                }

            }
            else //При бюджет по-голям от 3000лв.:
            {
                accomodation = "Hotel";
                vacationCost = budget - budget * 0.90;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else //winter
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {accomodation} - {budget - vacationCost:f2}");
        }
    }
}
