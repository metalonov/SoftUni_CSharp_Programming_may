using System.Diagnostics.CodeAnalysis;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, remainder = 0;
            int quot = n;

            while (quot != 0) 
            {
                remainder = quot % 10;
                quot = quot / 10;
                int fact = 1;
                for (int i = 1; i <= remainder; i++)
                {
                    fact = fact * i;
                }

                sum += fact;
            }
            if (sum == n)
            {
            Console.WriteLine("yes");

            }
            else
            {
            Console.WriteLine("no");

            }
        }
    }
}