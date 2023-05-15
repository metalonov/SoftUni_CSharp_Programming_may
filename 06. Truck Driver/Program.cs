using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn" или "Winter"
            double travelDistance = double.Parse(Console.ReadLine()); //Километри на месец – реално число в интервала[10.00...20000.00]
            double seasonPay = 0;
            
            //Един сезон е 4 месеца

            if (travelDistance <= 5000)
            {
                if (season == "Summer")
                {
                    seasonPay = travelDistance * 0.90;
                }
                else if (season == "Winter")
                {
                    seasonPay = travelDistance * 1.05;
                }
                else // пролет-есен 
                {
                    seasonPay = travelDistance * 0.75;
                }
            }
            else if (travelDistance <= 10000)
            {
                if (season == "Summer")
                {
                    seasonPay = travelDistance * 1.10;
                }
                else if (season == "Winter")
                {
                    seasonPay = travelDistance * 1.25;
                }
                else // пролет-есен 
                {
                    seasonPay = travelDistance * 0.95;
                }
            }
            else // <=20000
            {
                    seasonPay = travelDistance * 1.45;
            }
            double netPay = ((seasonPay * 0.9) *4);
            Console.WriteLine($"{netPay:f2}");
        }
    }
}
