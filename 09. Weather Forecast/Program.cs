using System;

namespace _09._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whatIsIt = Console.ReadLine();

            if (whatIsIt == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else 
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
