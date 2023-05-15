using System;

namespace _01._Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата три дробни числа b1, b2 и h
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double calc = ((b1 + b2) / 2) * h;

            Console.WriteLine($"{calc:f2}");
        }
    }
}
