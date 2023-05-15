using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:

            int travelDistance = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double travelExpenses = 0;
            if (travelDistance >= 100) //Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.
            {
                travelExpenses = (double)travelDistance * 0.06;
            }
            else if (travelDistance >= 20) //Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
            {
                travelExpenses = (double)travelDistance * 0.09;
            }
            else //Такси. Начална такса: 0.70 лв. Дневна тарифа: 0.79 лв. / км. Нощна тарифа: 0.90 лв. / км.
            {
                if (dayNight == "day")
                {
                    travelExpenses = ((double)travelDistance * 0.79) + 0.70;
                }
                else 
                {
                    travelExpenses = (double)travelDistance * 0.90 + 0.70;
                }
            }
            Console.WriteLine($"{travelExpenses:f2}");
        }
    }
}
