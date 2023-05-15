using System;

namespace _06._Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                for (int a = n; a < 9; a++) //find n нечетна
                {
                    if (a % 2 != 0)
                    {
                        n = a;
                    }
                }
                for (int b = m; b <= 8; b++) //find m четна
                {
                    if (b % 2 != 0)
                    {
                        m = b;
                    }
                }
                for (int c = l; c < 9; c++) //find l нечетна
                {
                    if (c % 2 != 0)
                    {
                        l = c;

                    }
                }
                for (int g = k; k < 8; g++) //find k четна
                {
                    if (g % 2 == 0) //първа четна, втора нечетна
                    {
                        k = g;
                    }
                }
                if (k==m && l==n)
                {
                    Console.WriteLine($"Cannot change the same player.");
                }
                if (n % 2 != 0 && l % 2 != 0 && k % 2 == 0 && m % 2 != 0)
                {
                    Console.WriteLine($"{k}{l} - {m}{n}");
                }
            }
        }
    }
}
