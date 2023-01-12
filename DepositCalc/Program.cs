using System;

namespace DepositCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double rate = deposit * percent / 100;
            double monthlyRate = rate / 12;
            double sum = deposit + months * monthlyRate;
            Console.WriteLine(sum);
        }
    }
}
