using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailonSq = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double razreditel = double.Parse(Console.ReadLine());
            double workHours = double.Parse(Console.ReadLine());
            double nailonSqTotal = (nailonSq + 2) * 1.5;
            double paintTotal = (paint + (paint / 10)) * 14.5;
            double razreditelTotal = razreditel * 5;
            double materials = nailonSqTotal + paintTotal + razreditelTotal + 0.4;
            double work = (materials * 0.3) * workHours;
            Console.WriteLine(materials + work);
        }
    }
}
