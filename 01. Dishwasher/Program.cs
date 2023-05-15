using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());
            int detergent = bottlesDetergent * 750;
            int washLoadCounter = 0; //на всяко трето зареждане със съдове, съдомиялната се пълни само с тенджери
            int washedDishCounter = 0;
            int washedPotCounter = 0;
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (detergent < 0)
                {
                    break;
                }
                washLoadCounter++;
                if (washLoadCounter % 3 == 0) //тенджера 15 мл.
                {
                    detergent = detergent - (int.Parse(input) * 15);
                    washedPotCounter += int.Parse(input);

                }
                else // 1 чиния са нужни 5 мл.
                {
                    detergent = detergent - (int.Parse(input) * 5);
                    washedDishCounter += int.Parse(input);
                }
            }
            if (detergent>=0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{washedDishCounter} dishes and {washedPotCounter} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
