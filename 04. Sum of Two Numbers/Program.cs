using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool flag = false;

            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    combination++;

                    int result = x1 + x2;
                    if (result == magicNumber)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{combination} ({x1} + {x2} = {magicNumber})");
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
