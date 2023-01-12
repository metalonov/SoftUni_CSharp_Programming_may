using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broiHimikali = double.Parse(Console.ReadLine());
            double broiMarkeri = double.Parse(Console.ReadLine());
            double litriPreparat = double.Parse(Console.ReadLine());
            double namalenie = double.Parse(Console.ReadLine());
            double totalHimikali = broiHimikali * 5.8;
            double totalMarkeri = broiMarkeri * 7.2;
            double totalPreparat = litriPreparat * 1.2;
            double namalenieProcent = namalenie / 100;
            double totalCena = totalHimikali + totalMarkeri + totalPreparat;
            Console.WriteLine(totalCena - totalCena * namalenieProcent);
        }
    }
}
