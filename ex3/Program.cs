using System;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for c");
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c)) 
            {
                Console.WriteLine("greater is a: " + a);
            }
            if ((b > a) && (b > c)) 
            {
                Console.WriteLine("greater is b: " + b);
            }
            if ((c > a) && (c > b))
            {
                Console.WriteLine("greater is c: " + c);
            }
        }
    }
}
