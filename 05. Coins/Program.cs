using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //монети от 2лв(200ст) 1лев (100ст), 50ст 20ст 10ст 5ст 2ст и 1ст

            double input = double.Parse(Console.ReadLine());
            input *= 100;
            int count = 0;
            while (input > 0)
            {
                if (input >= 200)
                {
                    input -= 200;
                }
                else if (input >= 100)
                {
                    input -= 100;
                }
                else if (input >= 50)
                {
                    input -= 50;
                }
                else if (input >= 20)
                {
                    input -= 20;
                }
                else if (input >= 10)
                {
                    input -= 10;
                }
                else if (input >= 5)
                {
                    input -= 5;
                }
                else if (input >= 2)
                {
                    input -= 2;
                }
                else if (input >= 1)
                {
                    input -= 1;
                }
                else
                {
                    input = 0;
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
