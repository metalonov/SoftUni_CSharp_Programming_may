using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //Входът се чете от конзолата и се състои от едно число – броят почивни дни – цяло число в интервала [0...365]
            int gametime = ((365 - x) * 63) + (x * 127); //in minutes
            int timeLeft = 0;

            if (gametime > 30000) // Ако времето за игра на Том е над нормата за текущата година:
            {
                int timeOver = gametime - 30000; //in minutes
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{timeOver / 60} hours and {timeOver % 60} minutes more for play");
            }
            else //Ако времето за игра на Том е под нормата за текущата година:
            {
                timeLeft = 30000 - gametime;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{timeLeft / 60} hours and {timeLeft % 60} minutes less for play");
            }
        }
    }
}
