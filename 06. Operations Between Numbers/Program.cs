using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int num1 = int.Parse(Console.ReadLine()); //която чете две цели числа (N1 и N2)
            int num2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine()); //оператор, с който да се извърши дадена математическа операция с тях.

            if (op == '+' || op == '-' || op == '*' ) //математическа операция с тях, 
            {
                int result;
                string evenOrOdd = "odd";

                if (op == '+')
                {
                    result = num1 + num2;
                }
                else if (op == '-')
                {
                    result = num1 - num2;
                }
                else // (op == '*')
                {
                    result = num1 * num2;
                }
                if (result%2==0) //При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен
                    {
                        evenOrOdd = "even";
                    }
                Console.WriteLine($"{num1} {op} {num2} = {result} - {evenOrOdd}");
            }

            else if (op == '/' || op == '%')
                {
                    if (num2 == 0)//Трябва да се има предвид, че делителят може да е равен на 0(нула)
                                               //, а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else if (op == '/')
                    {
                        double result = (double)num1 / num2;

                        Console.WriteLine($"{num1} {op} {num2} = {result:f2}");
                    }
                    else 
                    {
                        Console.WriteLine($"{num1} {op} {num2} = {num1 % num2}");
                    }
                }
        }
    }
}
