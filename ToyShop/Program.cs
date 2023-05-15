using System;
using System.Data.SqlTypes;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цена на екскурзията
            double tripFunds = double.Parse(Console.ReadLine());

            //кол. поръчани играчки:
            //пъзели, кукли, мечета, миньони, камиончета
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //намиране общия брой играчки
            int totalToys = puzzles + dolls + teddies + minions + trucks;

            //намиране обща цена
            double toysFunds = puzzles * 2.60 + dolls * 3 + teddies * 4.10 + minions * 8.20 + trucks * 2;
            //проверка броя за отстъпка
            if (totalToys >= 50)
            {
                toysFunds -= toysFunds * 0.25;
            }
            //изваждане за наем
            toysFunds -=  toysFunds * 0.1;
            //проверяваме дали има достатъчно за почивка
            if (toysFunds >= tripFunds)
            {
                Console.WriteLine($"Yes! {toysFunds - tripFunds:f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {tripFunds - toysFunds:f2} lv needed.");
            }
        }
    }
}
