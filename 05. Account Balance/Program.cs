using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accBalance = 0;
            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);
                if (depositAmount < 0) 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                accBalance += depositAmount;
                Console.WriteLine($"Increase: {depositAmount:f2}");
            }
            Console.WriteLine($"Total: {accBalance:f2}");
        }
    }
}
