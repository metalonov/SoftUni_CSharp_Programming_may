using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Едно парче торта е с размер 1х1 см.
            //input: шир и дължина на тортата
            int cakeHeight = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int wholeCake = cakeHeight * cakeLength;
            string input;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int pieces = int.Parse(input);
                wholeCake -= pieces;
                if (wholeCake < 0)
                {
                    break;
                }
            }
            if (wholeCake > 0)
            {
                Console.WriteLine($"{wholeCake} pieces are left.");
            }
            else 
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
            }
            //if statements: "{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            //"No more cake left! You need {брой недостигащи парчета} pieces more."
        }
    }
}
