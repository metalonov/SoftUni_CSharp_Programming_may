using System;

namespace _01._Moon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double litersPerHundred = double.Parse(Console.ReadLine());

            //Броят на часовете, за които Георги е отишъл и се е върнал
            //(резултатът да се закръгли до по-голямото цяло число).

            double tripTime = Math.Ceiling(768800 / speed) + 3;
            double fuelNeeded = (litersPerHundred * 768800) / 100;

            Console.WriteLine(tripTime);
            Console.WriteLine(fuelNeeded);
        }
    }
}
