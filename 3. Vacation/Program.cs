using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double acomodations = 0.0;

            if (peopleCount >= 100 && groupType == "Business") 
            {
                peopleCount -= 10;
            }

            if (weekDay == "Friday") 
            {
                if (groupType == "Students") 
                {
                    acomodations = peopleCount * 8.45;
                }
                if (groupType == "Business")
                {
                    acomodations = peopleCount * 10.90;
                }
                if (groupType == "Regular")
                {
                    acomodations = peopleCount * 15;
                }
            }
            if (weekDay == "Saturday")
            {
                if (groupType == "Students")
                {
                    acomodations = peopleCount * 9.80;
                }
                if (groupType == "Business")
                {
                    acomodations = peopleCount * 15.60;
                }
                if (groupType == "Regular")
                {
                    acomodations = peopleCount * 20;
                }
            }
            if (weekDay == "Sunday")
            {
                if (groupType == "Students")
                {
                    acomodations = peopleCount * 10.46;
                }
                if (groupType == "Business")
                {
                    acomodations = peopleCount * 16;
                }
                if (groupType == "Regular")
                {
                    acomodations = peopleCount * 22.50;
                }
            }
            if (groupType == "Students" && peopleCount >= 30) 
            {
                acomodations -= acomodations * 0.15;
            }
            if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                acomodations -= acomodations * 0.15;
            }
            Console.WriteLine($"Total price: {acomodations:f2}");
        }
    }
}
