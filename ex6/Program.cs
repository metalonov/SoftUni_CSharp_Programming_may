using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //﻿6.   Напишете програма, която при въвеждане на коефициентите (a, b и c)
            //  на квадратно уравнение: ax2 + bx + c, изчислява и извежда неговите реал -
            //  ни корени(ако има такива).Квадратните уравнения могат да имат 0, 1
            //  или 2 реални корена.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = ((b * b) - 4 * a * c);
            if (D == 0) 
            {
                double x1 = -b / 2 * a;
                Console.WriteLine(x1);
            }
            if (D > 0)
            {
                double x1 = -b + Math.Sqrt(b * b - 4 * a * c) / 2 * a;
                double x2 = -b - Math.Sqrt(b * b - 4 * a * c) / 2 * a;
                Console.WriteLine("X1 is: " + x1);
                Console.WriteLine("X2 is: " + x2);
            }
            if (D < 0)
            {
                Console.WriteLine("nqma realni koreni");
            }
        }
    }
}
