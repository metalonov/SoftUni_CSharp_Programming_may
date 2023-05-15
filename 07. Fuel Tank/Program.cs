using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                fuelType = fuelType.ToLower();
                if (liters >= 25) //Ако литрите гориво са повече или равни на 25
                {
                    Console.WriteLine($"You have enough {fuelType}.");
                }
                else // ако са по-малко от 25
                {
                    Console.WriteLine($"Fill your tank with {fuelType}!");
                }
            }
            else 
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
