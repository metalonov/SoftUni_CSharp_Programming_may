using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total weight of a container in grams: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total price of a container(use . instead of ,): ");
            double price = double.Parse(Console.ReadLine());
            double hundredgramsdrob = weight / 100;
            double pph = price / hundredgramsdrob;
            double ppk = pph * 10;
            Console.WriteLine("The price per kilo is: " + ppk + ".lv");

        }
    }
}
