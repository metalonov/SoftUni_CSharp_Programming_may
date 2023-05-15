using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //1. Сезонът – текст - “Winter”, “Spring” или “Summer”;
            string groupType = Console.ReadLine();  //2. Видът на групата – текст - “boys”, “girls” или “mixed”;
            int studentAmount = int.Parse(Console.ReadLine()); //3. Брой на учениците – цяло число в интервала [1 … 10000];
            int stayNight = int.Parse(Console.ReadLine());  //4. Брой на нощувките – цяло число в интервала [1 … 100].
            string sportType;
            double accomodationCost = 0;

            if (season == "Winter")
            {
                if (groupType == "boys")
                {
                    sportType = "Judo";
                    accomodationCost = (double)studentAmount * stayNight * 9.6;
                }
                else if (groupType == "girls")
                {
                    sportType = "Gymnastics";
                    accomodationCost = (double)studentAmount * stayNight * 9.6;
                }
                else //mixed
                {
                    sportType = "Ski";
                    accomodationCost = (double)studentAmount * stayNight * 10;
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys")
                {
                    sportType = "Tennis";
                    accomodationCost = (double)studentAmount * stayNight * 7.2;
                }
                else if (groupType == "girls")
                {
                    sportType = "Athletics";
                    accomodationCost = (double)studentAmount * stayNight * 7.2;
                }
                else //mixed
                {
                    sportType = "Cycling";
                    accomodationCost = (double)studentAmount * stayNight * 9.5;
                }
            }
            else // (season == "Summer")
            {
                if (groupType == "boys")
                {
                    sportType = "Football";
                    accomodationCost = (double)studentAmount * stayNight * 15;
                }
                else if (groupType == "girls")
                {
                    sportType = "Volleyball";
                    accomodationCost = (double)studentAmount * stayNight * 15;
                }
                else //mixed
                {
                    sportType = "Swimming";
                    accomodationCost = (double)studentAmount * stayNight * 20;
                }
            }
            //discounts
            if (studentAmount >= 10 && studentAmount < 20) //Ако броят на учениците е 10 или повече и в същото време
                                     //по-малък от 20, училището получава 5% отстъпка
            {
                accomodationCost = accomodationCost - accomodationCost * 0.05;
            }
            else if (studentAmount >= 20 && studentAmount < 50) //Ако броят на учениците е 20 или повече и в същото
                                          //време по-малък от 50, училището получава 15% отстъпка
            {
                accomodationCost = accomodationCost - accomodationCost * 0.15;
            }
            else if (studentAmount >= 50) //Ако броят на учениците е 50 или повече, училището получава 50% отстъпка
            {
                accomodationCost = accomodationCost - accomodationCost * 0.5;
            }
            //пресмята цената, която ще заплати училището за нощувките и
            //принтира спорта, който ще се практикува от учениците.
            Console.WriteLine($"{sportType} {accomodationCost:f2} lv.");
        }
    }
}
