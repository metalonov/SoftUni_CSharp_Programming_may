using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double delay = Math.Floor(distance / 15)*12.5;
            double personalRecord = distance * timePerMeter + delay;
            if (personalRecord < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {personalRecord:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - personalRecord):f2} seconds slower.");
            }
        }
    }
}
