using System;

namespace _02._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double calc = (a * h)/2;

                Console.WriteLine($"{calc:f2}");
            }
        }
    }
}
