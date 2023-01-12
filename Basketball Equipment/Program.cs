using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualTax = double.Parse(Console.ReadLine());
            double runners = annualTax - (annualTax * 0.4);
            double clothes = runners - (runners * 0.2);
            double basketBall = clothes / 4;
            double accesory = basketBall / 5;
            Console.WriteLine(annualTax + runners+ clothes + basketBall + accesory);   
        }
    }
}
