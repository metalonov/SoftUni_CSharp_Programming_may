using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); //Първи ред - дни за престой - цяло число в интервала [0...365]
            string accomodation = Console.ReadLine(); //Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
            string rating = Console.ReadLine(); //Трети ред - оценка - "positive"  или "negative"
            int nights = days - 1;
            double costPerNight = 0;
            double totalCost = 0;

            switch (accomodation)
            {
                case "room for one person": //не ползва намаление
                    costPerNight = 18.00;
                    totalCost = costPerNight * nights;
                    break;
                case "apartment": 
                    costPerNight = 25.00;
                    if (days < 10) //apartment, 30 % от крайната цена
                    {
                        totalCost = costPerNight * nights;
                        totalCost -= totalCost * 0.30;
                    }
                    else if (days >= 10 && days <= 15) //35 % от крайната цена
                    {
                        totalCost = costPerNight * nights;
                        totalCost -= totalCost * 0.35;
                    }
                    else //50% от крайната цена
                    {
                        totalCost = costPerNight * nights;
                        totalCost -= totalCost * 0.50;
                    }
                    break;
                case "president apartment":
                    costPerNight = 35.00;
                    if (days < 10) //10% от крайната цена
                    {
                        totalCost = costPerNight * nights;
                        totalCost -= totalCost * 0.10;                        
                    }
                    else if (days >= 10 && days <= 15) //15% от крайната цена
                    {
                        totalCost = costPerNight * nights; 
                        totalCost -= totalCost * 0.15;
                    }
                    else  //20% от крайната цена
                    {
                        totalCost = costPerNight * nights;
                        totalCost -= totalCost * 0.20;
                    }
                    break;
            }
            if (rating == "positive") //Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25%
            {
                totalCost += totalCost * 0.25;
            }
            else //Ако оценката му е негативна приспада от цената 10%.
            {
                totalCost -= totalCost * 0.10;
            }
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
