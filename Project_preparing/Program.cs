using System;

namespace Project_preparing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int projTime = 3;
            string name = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int totalTime = projTime * amount;
            Console.WriteLine("The architect " + name + " will need " + totalTime + " hours to complete " + amount + " project/s.");
        }
    }
}
