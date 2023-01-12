using System;

namespace Inch_to_centimeter_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.54;
            Console.WriteLine("Enter inch value: ");
            double b = double.Parse(Console.ReadLine());
            double calc = a * b;
            Console.WriteLine("Answer is " + calc);
        }
    }
}
