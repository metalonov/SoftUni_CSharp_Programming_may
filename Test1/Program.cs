using System;

namespace CalcSteps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your stride length in centimmeters: ");
            double strideLength = double.Parse(Console.ReadLine());
            strideLength = (strideLength / 100);
            Console.WriteLine("Enter distance in kilometers.");
            double distance = double.Parse(Console.ReadLine());
            distance = (distance * 1000);
            Console.WriteLine("Steps amount is " + distance / strideLength + " steps.");

        }
    }
}
