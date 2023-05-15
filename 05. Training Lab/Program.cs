using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double centLength = length * 100;
            double freeCentWidth = (width * 100) - 100; //Коридорът е широк поне 100 cm. in meters
            double desksPerRow = Math.Floor(centLength / 120); //Едно работно място заема 70 
            double desksPerLine = Math.Floor(freeCentWidth / 70); //на 120 cm

            Console.WriteLine((desksPerLine * desksPerRow) - 3);
        }
    }
}
