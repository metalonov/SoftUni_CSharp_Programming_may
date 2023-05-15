using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си. 
            //Един кашон е с точни размери:  1m. x 1m. x 1m.
            int flatWidth = int.Parse(Console.ReadLine());
            int flatLength = int.Parse(Console.ReadLine());
            int flatHeigth = int.Parse(Console.ReadLine());
            int flatSpace = flatWidth * flatLength * flatHeigth;
            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                int boxes = int.Parse(input);
                flatSpace -= boxes;
                if (flatSpace < 0)
                {
                    break;
                }
            }
            //Да се отпечата на конзолата един от следните редове:
            if (flatSpace > 0) //Ако стигнете до командата "Done" и има още свободно място:
            {
                Console.WriteLine($"{flatSpace} Cubic meters left.");
            }
            else //Ако свободното място свърши преди да е дошла команда "Done":
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(flatSpace)} Cubic meters more.");
            }
        }
    }
}
