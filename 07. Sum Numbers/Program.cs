﻿using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int sum = 0; //defaults for sums(+) is always 0, products(*) are always 1

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
