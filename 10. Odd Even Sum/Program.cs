using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //която чете n-на брой цели числа, подадени от потребителя
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= n; i++) 
            {
                int element = int.Parse(Console.ReadLine());

                if (i % 2 == 0) //четни
                {
                    evenSum += element;
                }
                else  //нечетни
                {
                    oddSum += element;
                } 
            }
            if (oddSum == evenSum) //проверява дали сумата от числата на четни позиции
                                   //е равна на сумата на числата на нечетни позиции. 
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else 
            {
                Console.WriteLine("No"); //Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата. 
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}"); //Разликата се изчислява по абсолютна стойност.                                          
            }
        }
    }
}
