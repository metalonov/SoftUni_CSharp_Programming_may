using System;

namespace TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += hours * 60;
            minutes += 15;
            hours = minutes / 60;
            minutes = minutes % 60;
            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
