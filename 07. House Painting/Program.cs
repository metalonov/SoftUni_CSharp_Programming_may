using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); //1.x – височината на къщата – реално число в интервала[2...100]
            double y = double.Parse(Console.ReadLine()); //2. y – дължината на страничната стена – реално число в интервала [2...100]
            double h = double.Parse(Console.ReadLine()); //3. h – височината на триъгълната стена на прокрива – реално число в интервала [2...100]

            double sideWall = (x * y)*2 - 4.5;
            double rearFront = (x * x - 2.4)+ x * x;
            double roofTotal = 2 * (x * y) + (x * h);

            double totalGreen = (sideWall + rearFront)/ 3.4;
            double totalRed = roofTotal/4.3;

            Console.WriteLine($"{totalGreen:f2}");
            Console.WriteLine($"{totalRed:f2}");

        }
    }
}
