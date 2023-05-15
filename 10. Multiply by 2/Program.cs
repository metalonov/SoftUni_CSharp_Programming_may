using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            while (true)
            {
                num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    num *= 2;
                    Console.WriteLine($"Result: {num:f2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
            }
        }
    }
}
