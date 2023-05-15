using System;

namespace _2._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int biggest = 0;
            bool divisible = false;

            if (num % 2 == 0)
            {
                biggest = 2;
                divisible = true;
            }
            if (num % 3 == 0)
            {
                biggest = 3;
                divisible = true;
            }
            if (num % 6 == 0)
            {
                biggest = 6;
                divisible = true;
            }
            if (num % 7 == 0)
            {
                biggest = 7;
                divisible = true;
            }
            if (num % 10 == 0)
            {
                biggest = 10;
                divisible = true;
            }
            if (divisible == true)
            {
                Console.WriteLine($"The number is divisible by {biggest}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
