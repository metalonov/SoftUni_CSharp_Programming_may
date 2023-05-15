using System;

namespace dataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 40;
            if (first == second)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine($"The number {first} is greater than {second}");
                }
                else
                {
                    Console.WriteLine($"The number {first} is lower than {second}");
                }
            }
        }
    }
}
