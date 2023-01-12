using System;

namespace Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int perHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = pages / perHour;
            int neededDays = hours / days;
            Console.WriteLine(neededDays);
        }
    }
}
