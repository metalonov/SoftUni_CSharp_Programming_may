using System;

namespace ExellectResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double results = double.Parse(Console.ReadLine());
            if (results >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
