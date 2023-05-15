using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
