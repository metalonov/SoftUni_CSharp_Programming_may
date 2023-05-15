using System;

namespace _02._AND_Processors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cpuAmount = int.Parse(Console.ReadLine());
            int slaves = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double calculation = Math.Floor(((double)slaves * days * 8.0) / 3.0);
            double loss = Math.Abs((double)cpuAmount - calculation) * 110.10;

            //output
            if (cpuAmount < calculation)
            {
                Console.WriteLine($"Profit: -> {loss:f2} BGN");
            }
            else if (cpuAmount > calculation)
            { 
                Console.WriteLine($"Losses: -> {loss:f2} BGN");
            }

        }
    }
}
