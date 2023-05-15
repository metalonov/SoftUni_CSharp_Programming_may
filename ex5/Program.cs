using System;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ﻿5.   Напишете програма, която за дадена цифра (0-9),
            // зададена като вход,
            int num = int.Parse(Console.ReadLine());

            //извежда името на цифрата на английски език.Използвайте switch
            //конструкция.

            switch (num)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

                default:
                    Console.WriteLine("unknown number"); break;

            }
        }
    }
}
