using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double totalCapacity = (length * width * height) / 1000;
            double items = percentage / 100;
            Console.WriteLine(totalCapacity * (1 - items));
        }
    }
}
