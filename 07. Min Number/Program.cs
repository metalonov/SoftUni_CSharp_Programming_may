using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
