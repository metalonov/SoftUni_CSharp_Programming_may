using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumria = double.Parse(Console.ReadLine()); //цена на скумрията на килограм
            double tzatza = double.Parse(Console.ReadLine()); //цена на цацата на килограм
            double palamud = double.Parse(Console.ReadLine()); //килограма паламуд
            double safrid = double.Parse(Console.ReadLine()); //килограма сафрид
            double shellfish = double.Parse(Console.ReadLine()); //килограма миди

            double costOfPalamud = (palamud * (skumria + (skumria * 0.6)));
            double costOfSafrid = (safrid * (tzatza + (tzatza * 0.8)));
            double costOfShellfish = shellfish * 7.50;
            double bill = costOfPalamud + costOfSafrid + costOfShellfish;

            Console.WriteLine($"{bill:f2}");
        }
    }
}
