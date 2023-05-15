using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат точно три реда.
            //Бюджет на групата – цяло число в интервала[1…8000]
            int budget = int.Parse(Console.ReadLine());
            //Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            string season = Console.ReadLine();
            //Брой рибари – цяло число в интервала[4…18]
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;

            //Цената зависи от сезона:
            
            switch (season)
            {
                case "Spring": //Цената за наем на кораба през пролетта е  3000 лв.
                    price = 3000;
                    //В зависимост от броя си групата ползва отстъпка:
                    if (fishermen <= 6)
                    {
                        //Ако групата е до 6 човека включително  –  отстъпка от 10 %
                        price -= price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)//Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
                    {
                        price -= price * 0.15;
                    }
                    else if (fishermen >= 12) //Ако групата е от 12 нагоре  –  отстъпка от 25 %.
                    {
                        price -= price * 0.25;
                    }
                    break;

                //Цената за наем на кораба през лятото и есента е  4200 лв.
                case "Autumn":
                case "Summer":
                price = 4200;
                    
                    if (fishermen <= 6)//В зависимост от броя си групата ползва отстъпка:
                    {
                        price -= price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)//Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
                    {
                        price -= price * 0.15;
                    }
                    else if (fishermen >= 12)//Ако групата е от 12 нагоре  –  отстъпка от 25 %.
                    {
                        price -= price * 0.25;
                    }
                    break;

                //Цената за наем на кораба през зимата е  2600 лв.
                case "Winter":
                price = 2600;
                    //В зависимост от броя си групата ползва отстъпка:
                    if (fishermen <= 6)//Ако групата е до 6 човека включително  –  отстъпка от 10 %
                    {
                        
                        price -= price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)//Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
                    {

                        price -= price * 0.15;
                    }
                    else if (fishermen >= 12)//Ако групата е от 12 нагоре  –  отстъпка от 25 %.
                    {
                        price -= price * 0.25;
                    }
                    break;
                default:
                    break;
            }
            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен
            //- тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
            if (fishermen % 2 == 0 && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                price -= price * 0.05;
            }
            if (budget - price >= 0)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - price):f2} leva.");
            }

        }
    }
}
