using System;

namespace _08._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * (r * r):f2}"); //"<calculated area>"
            Console.WriteLine($"{(Math.PI * 2) * r:f2}"); //"<calculated parameter>"
        }
    }
}
