using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int primeSum = 0;
            int nonPrimeSum = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
                bool isPrime = true;
                int currentNum = int.Parse(input);
                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < currentNum; i++)
                    {
                        if (currentNum % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime && currentNum>0) 
                {
                    primeSum += currentNum;
                }
                else if (currentNum>0)
                {
                    nonPrimeSum += currentNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
