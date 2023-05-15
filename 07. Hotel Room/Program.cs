using System;
using System.Diagnostics.CodeAnalysis;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine(); //На първия ред е месецът – May, June, July, August, September или October
            int nights = int.Parse(Console.ReadLine()); //На втория ред е броят на нощувките – цяло число в интервала
            double studio = 0;
            double flat = 0;

            switch (month)
            {

                case "May":
                    studio = 50; //Студио – 50 лв./нощувка
                    flat = 65; //Апартамент – 65 лв./нощувка
                    break;
                case "October":
                    studio = 50;
                    flat = 65;
                    break;
                case "June":
                    studio = 75.20; //Студио – 75.20 лв./ нощувка
                    flat = 68.70; //Апартамент – 68.70 лв./нощувка
                    break;
                case "September":
                    studio = 75.20;
                    flat = 68.70;
                    break;
                case "July":
                    studio = 76; //Студио – 76 лв./нощувка
                    flat = 77; //Апартамент – 77 лв./нощувка
                    break;
                case "August":
                    studio = 76;
                    flat = 77;
                    break;
            }

            if ((nights > 7 && nights < 14) && (month == "May" || month == "October"))
            {
                studio -= studio * 0.05;
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                studio -= studio * 0.30;
            }

            if (nights > 14 && (month == "June" || month == "September"))
            {
                studio -= studio * 0.20;
            }

            if (nights > 14) 
            {
                flat -= flat * 0.10;
            }
            Console.WriteLine($"Apartment: {(double)nights * flat:f2} lv."); //На първия ред: “Apartment: {цена за целият престой} lv.”
            Console.WriteLine($"Studio: {(double)nights * studio:f2} lv."); //На втория ред: “Studio: {цена за целият престой} lv.“
        }
    }
}
