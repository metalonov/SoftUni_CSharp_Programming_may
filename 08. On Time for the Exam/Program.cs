using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да отиде на изпит в определен час(например в 9:30 часа).Той идва в изпитната зала в даден час на пристигане(например 9:40).
            //Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.Ако е пристигнал по-рано повече от
            //30 минути, той е подранил.Ако е дошъл след часа на изпита, той е закъснял.Напишете програма, която прочита време на изпит и време на пристигане
            //и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
        
            int hour = int.Parse(Console.ReadLine()); //Първият ред съдържа час на изпита – цяло число от 0 до 23.
            int minute = int.Parse(Console.ReadLine()); //Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            int arrivalHour = int.Parse(Console.ReadLine()); //Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            int arrivalMinute = int.Parse(Console.ReadLine()); //Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int allMinute = hour * 60 + minute;
            int allArrival = arrivalHour * 60 + arrivalMinute;
            int difference = allMinute - allArrival;

            if (difference < 0) //late
            {
                Console.WriteLine("Late");
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours after the start");
                }

            }
            else if (difference <= 30 && difference >= 0) //on time
            {
                Console.WriteLine("On time");
                if (difference > 0)
                {
                    Console.WriteLine($"{difference % 60} minutes before the start");
                }
            }
            else //early, over 30min
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else 
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours before the start");
                }
            }
        }
    }
}
