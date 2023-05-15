using System;

namespace showPlusOrMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = -20;
            int c = 30;
            int sum = a * b * c;
            if (sum > 0)
            {
                Console.WriteLine("+");
            }
            else 
            {
                Console.WriteLine("-");
            }
        }
    }
}
