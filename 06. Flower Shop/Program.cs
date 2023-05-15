using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine()); //Брой магнолии – цяло число в интервала [0 … 50]
            int zyumbyuli = int.Parse(Console.ReadLine());  //Брой зюмбюли – цяло число в интервала [0 … 50]
            int roses = int.Parse(Console.ReadLine());  //Брой рози – цяло число в интервала [0 … 50]
            int cactus = int.Parse(Console.ReadLine());  //Брой кактуси – цяло число в интервала [0 … 50]
            double price = double.Parse(Console.ReadLine()); //Цена на подаръка – реално число в интервала [0.00 … 500.00]

            double smetka = (((double)magnolii * 3.25) + ((double)zyumbyuli * 4) + ((double)roses * 3.50) + ((double)cactus * 8)) * 0.95;

            if (smetka >= price)
            {
                Console.WriteLine($"She is left with {Math.Floor(smetka - price)} leva."); //сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1)
            }
            else 
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(price - smetka)} leva.");  //сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2)
            }
        }
    }
}
