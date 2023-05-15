using System;

namespace upraznenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 2;
            if (num1 < num2) 
            {
                Console.WriteLine($"{num2} is greater!");
            }
            else 
            {
                Console.WriteLine($"{num1} is greater!");
                if (num1 > num2)
                {
                    int num3 = num1;
                    num1 = num2;
                    num2 = num3;
                    Console.WriteLine($"num1 is {num1} and num2 is {num2} ");
                }

            }
        }
    }
}