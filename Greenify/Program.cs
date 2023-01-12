using System;

namespace Greenify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            double price = amount * 7.61;
            double discount = 0.18 * price;
            double discountedPrice = price - discount;
            Console.WriteLine("The final price is: " + discountedPrice + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
        }
    }
}
