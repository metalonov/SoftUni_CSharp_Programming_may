﻿using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст)
            //- въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време
            //на офисът е от 10-18 часа, от понеделник до събота включително

            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((hour >= 10 && hour <= 18) && (day == "Monday" || day == "Tuesday" || day == "Thursday" || day == "Wednesday" || day == "Friday" || day == "Saturday")) 
                    {
                Console.WriteLine("open");
            }
            else 
            {
                Console.WriteLine("closed");
            }
        }
    }
}
