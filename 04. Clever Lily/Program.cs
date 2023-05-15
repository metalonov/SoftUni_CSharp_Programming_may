using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int savings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) //even number, money 
                {
                    savings += i * 5 - 1; //сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден
                }
                else //odd number, toys
                {
                    savings += toyPrice;
                }
            }
            if (savings >= washerPrice)
                Console.WriteLine($"Yes! {savings - washerPrice:f2}");
            else
                Console.WriteLine($"No! {Math.Abs(savings - washerPrice):f2}");
        }
    }
}
