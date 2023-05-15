using System;
using System.Runtime.Intrinsics.X86;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел.
            //Ако е в Европа, независимо от сезона ще почива в хотел. 

            //Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 

            
            double budget = double.Parse(Console.ReadLine()); //Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
            string season = Console.ReadLine(); //Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            string destination = "";
            string accomodation = ""; //Почивката може да е между „Camp” и „Hotel”
            double expenses = 0;

            if (budget <= 100 && (season == "summer" || season == "winter")) //При 100лв. или по-малко – някъде в България
            {
                if (season == "summer") //Ако е лято ще почива на къмпинг, 
                {
                    expenses = budget * 0.3;
                    destination = "Bulgaria";
                    accomodation = "Camp";
                }
                else //(season == "winter") //а зимата в хотел. 
                {
                    expenses = budget * 0.7;
                    destination = "Bulgaria";
                    accomodation = "Hotel";
                }
            }
            else if ((budget > 100 && budget <= 1000) && (season == "summer" || season == "winter")) //При 1000лв. или по малко – някъде на Балканите
            {
                if (season == "summer")
                {
                    expenses = budget * 0.4;
                    destination = "Balkans";
                    accomodation = "Camp";
                }
                else // (season == "winter")
                {
                    expenses = budget * 0.8;
                    destination = "Balkans";
                    accomodation = "Hotel";
                }
            }
            else  //(budget > 1000) //При повече от 1000лв. – някъде из Европа
            {
                expenses = budget * 0.9;
                destination = "Europe";
                accomodation = "Hotel";
            }
            
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accomodation} - {expenses:f2}");

        } 
    }
}
