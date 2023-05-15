using System;

namespace _03._Pastry_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pastry = Console.ReadLine();
            int sweetsAmt = int.Parse(Console.ReadLine());
            int dayOfDec = int.Parse(Console.ReadLine());
            double priceCalc = 0.0;

            if (dayOfDec <= 15)
            {
                if (pastry == "Cake")
                {
                    priceCalc = (double)sweetsAmt * 24;
                }
                else if (pastry == "Souffle")
                {
                    priceCalc = (double)sweetsAmt * 6.66;
                }
                else if (pastry == "Baklava")
                {
                    priceCalc = (double)sweetsAmt * 12.60;
                }
            }
            else // 16 dec on...
            {
                if (pastry == "Cake")
                {
                    priceCalc = (double)sweetsAmt * 28.70;
                }
                else if (pastry == "Souffle")
                {
                    priceCalc = (double)sweetsAmt * 9.80;
                }
                else if (pastry == "Baklava")
                {
                    priceCalc = (double)sweetsAmt * 16.98;
                }
            }
            if (dayOfDec <= 22)
            {
                if (priceCalc >= 100 && priceCalc <= 200)
                {
                    priceCalc -= priceCalc * 0.15;
                }
                else if (priceCalc > 200)
                {
                    priceCalc -= priceCalc * 0.25;
                }
                if (dayOfDec <= 15)
                {
                    priceCalc -= priceCalc * 0.10;
                }
            }


            //форматирана до втория знак след десетичната запетая = :f2

            Console.WriteLine($"{priceCalc:f2}");
        }
    }
}
