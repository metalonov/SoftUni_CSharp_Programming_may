using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); //чете 2*n-на брой цели числа, подадени от потребителя
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= count; i++)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= count; i++)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
            if (oddSum == evenSum) //проверява дали сумата на първите n числа
                                     //(лява сума) е равна на сумата на вторите n числа (дясна сума)
            {
                //При равенство печата " Yes, sum = " + сумата;
                Console.WriteLine($" Yes, sum = {oddSum}");
            }
            else
            {
                //иначе печата " No, diff = " + разликата. Разликата се изчислява като положително число (по абсолютна стойност). 
                Console.WriteLine($" No, diff = {Math.Abs(oddSum - evenSum)}");
            }

        }
    }
}
