using System;
using System.Runtime.InteropServices;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(реално число) , въведени от потребителя, и изчислява
            //и извежда размера на търговската комисионна според горната таблица.Резултатът да се изведе форматиран до 2 цифри след десетичната 
            //точка. При невалиден град или обем на продажбите(отрицателно число) да се отпечата "error".

            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if ((city == "Sofia" || city == "Plovdiv" || city == "Varna") && (sales >= 0))
            {
                if (city == "Sofia")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.12;
                    }
                }
                if (city == "Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = sales * 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.13;
                    }
                }
                if (city == "Plovdiv")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.145;
                    }
                }
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
