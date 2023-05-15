using System;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 67;
            int b = 69;
            int c = 68;
            if ((a > b) && (a > c) && (b > c))
            {
                Console.WriteLine($"first is {a} then {b} then {c}");
            }
            else 
            {
                Console.WriteLine($"first is {a} then {c} then {b}");
            }
            if ((b > a) && (b > c) && (a > c))
            {
                Console.WriteLine($"first is {b} then {a} then {c}");
            }
            else 
            {
                Console.WriteLine($"first is {b} then {c} then {a}");
            }
            if ((c > a) && (c > b) && (a > b))
            {
                Console.WriteLine($"first is {c} then {a} then {b}");
            }
            else 
            {
                Console.WriteLine($"first is {c} then {b} then {a}");
            }
        }
    }
}
