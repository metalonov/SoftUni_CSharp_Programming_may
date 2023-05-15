using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plosht = int.Parse(Console.ReadLine()); //1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000]
            double grapesKilo = double.Parse(Console.ReadLine()); //2ри ред: Y грозде за един кв.м – реално число в интервала [0.00 … 10.00]
            int wineNeeded = int.Parse(Console.ReadLine()); //3ти ред: Z нужни литри вино – цяло число в интервала [10 … 600]
            int workers = int.Parse(Console.ReadLine()); //4ти ред: брой работници – цяло число в интервала [1 … 20]

            double wineOutput = (grapesKilo * plosht * 0.4) / 2.5;
            //Напишете програма, която пресмята колко вино може да се произведе и дали това количество е достатъчно.
            //Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.

            if (wineNeeded > wineOutput)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wineOutput)} liters wine needed."); //Резултатът трябва да е закръглен към по-ниско цяло число

            }
            else 
            {
                double wineWorker = Math.Ceiling((wineOutput - wineNeeded) / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineOutput)} liters."); //Резултатът трябва да е закръглен към по-ниско цяло число
                Console.WriteLine($"{Math.Ceiling(wineOutput - wineNeeded)} liters left -> {wineWorker} liters per person.");
            }

        }
    }
}
