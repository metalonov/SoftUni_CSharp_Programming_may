using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double income = row * column;

            if (ticketType == "Premiere")
            {
                income *= 12; 
            }
            else if (ticketType == "Normal")
            {
                income *= 7.5;
            }
            else
            {
                income *= 5;
            }

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
