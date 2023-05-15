using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine(); //Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            double liters = double.Parse(Console.ReadLine()); //Количество гориво – реално число в интервала[1.00 … 50.00]
            string clubCard = Console.ReadLine();
            double cost = 0;

            if (fuelType == "Gas") 
            {
                if (clubCard == "Yes") //8 ст. за литър газ.
                {
                    cost = liters * 0.85;
                }
                else //clubCard no 
                {
                    cost = liters * 0.93;
                }
            }
            if (fuelType == "Gasoline")
            {
                if (clubCard == "Yes") ////18 ст. за литър бензин
                {
                    cost = liters * 2.04;
                }
                else //clubCard no 
                {
                    cost = liters * 2.22;
                }
            }
            if (fuelType == "Diesel")
            {
                if (clubCard == "Yes") //12 ст. за литър дизел
                {
                    cost = liters * 2.21;
                }
                else //clubCard no 
                {
                    cost = liters * 2.33;
                }
            }
            if (liters >= 20 && liters <= 25) 
            {
                cost = cost - cost * 0.08;
            }
            if (liters > 25) 
            {
                cost = cost - cost * 0.1;
            }
            Console.WriteLine($"{cost:f2} lv.");
        }
    }
}
