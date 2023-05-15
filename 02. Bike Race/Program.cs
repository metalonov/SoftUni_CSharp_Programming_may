using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //участниците са разпределени в младша("juniors") и старша("seniors") група.
            //таксата за участие на велосипедистите. Според възрастовата група и вида на трасето
            //input
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();
            double collectedTax = 0;

            if (trackType == "trail") 
            {
                collectedTax = ((double)junior * 5.5) + ((double)senior * 7);
            }
            else if (trackType == "cross-country")
            {
                collectedTax = ((double)junior * 8) + ((double)senior * 9.5);
                if ((junior + senior) >= 50)
                {
                    collectedTax = collectedTax - (collectedTax * 0.25);            //50 или повече(общо) такса -25%
                }
            }
            else if (trackType == "downhill")
            {
                collectedTax = ((double)junior * 12.25) + ((double)senior * 13.75);
            }
            else //(trackType == "road")
            {
                collectedTax = ((double)junior * 20) + ((double)senior * 21.50);
            }
            //output
            double taxExpenses = collectedTax - collectedTax * 0.05;             //5% се отделят за разходи
            Console.WriteLine($"{taxExpenses:f2}");
        }
    }
}
