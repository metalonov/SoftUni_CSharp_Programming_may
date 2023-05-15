using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int hrizantemi = int.Parse(Console.ReadLine()); //закупените хризантеми – цяло число в интервала [0 ... 200]
            int rozi = int.Parse(Console.ReadLine()); //закупените рози – цяло число в интервала [0 ... 200]
            int laleta = int.Parse(Console.ReadLine()); //закупените лалета – цяло число в интервала [0 ... 200]
            string season = Console.ReadLine(); //сезона – [Spring, Summer, Аutumn, Winter]
            string holyday = Console.ReadLine(); //празник – [Y – да / N - не]
            double brutePrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                if (holyday == "N")
                {
                    brutePrice = ((double)hrizantemi * 2) + ((double)rozi * 4.10) + ((double)laleta * 2.50);
                }
                else  //В празнични дни цените на всички цветя се увеличават с 15%
                {
                    brutePrice = ((double)hrizantemi * 2) + ((double)rozi * 4.10) + ((double)laleta * 2.50);
                    brutePrice = brutePrice + brutePrice * 0.15;
                }
            }

            else //(season == "Аutumn" || season == "Winter")
            {
                if (holyday == "N")
                {
                    brutePrice = ((double)hrizantemi * 3.75) + ((double)rozi * 4.50) + ((double)laleta * 4.15);
                }
                else  //В празнични дни цените на всички цветя се увеличават с 15%
                {
                    brutePrice = ((double)hrizantemi * 3.75) + ((double)rozi * 4.50) + ((double)laleta * 4.15);
                    brutePrice = brutePrice + brutePrice * 0.15;
                }
            }

            if (season == "Spring" && laleta > 7) //повече от 7 лалета през пролетта – 5% от цената на целият букет.
            {
                brutePrice = brutePrice - (brutePrice * 0.05);
            }
            if (season == "Winter" && rozi >= 10) //10 или повече рози през зимата – 10% от цената на целият букет.
            {
                brutePrice = brutePrice - (brutePrice * 0.1);
            }
            if (hrizantemi+rozi+laleta >= 20) //повече от 20 цветя общо през всички сезони – 20% от цената на целият букет.
            {
                brutePrice = brutePrice - (brutePrice * 0.2);
            }
            //Цената за аранжиране на букета винаги е 2лв
            Console.WriteLine($"{brutePrice+2:f2}");
        }
    }
}
