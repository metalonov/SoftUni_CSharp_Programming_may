using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intialSum = int.Parse(Console.ReadLine());
            int numbersSum = 0;
            while (numbersSum < intialSum) 
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbersSum += currentNumber;
            }
            Console.WriteLine(numbersSum);
        }
    }
}
