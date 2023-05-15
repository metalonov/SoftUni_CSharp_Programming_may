using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            //ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (реално число) ,
            //въведени от потребителя, и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с
            //2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error". 

            string name = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (name == "banana" || name == "apple" || name == "orange" || name == "grapefruit" || name == "kiwi" || name == "pineapple" || name == "grapes")
            {
                if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
                {
                    if (name == "banana")
                        Console.WriteLine($"{(amount * 2.50):f2}");
                    else if (name == "apple")
                        Console.WriteLine($"{(amount * 1.20):f2}");
                    else if (name == "orange")
                        Console.WriteLine($"{(amount * 0.85):f2}");
                    else if (name == "grapefruit")
                        Console.WriteLine($"{(amount * 1.45):f2}");
                    else if (name == "kiwi")
                        Console.WriteLine($"{(amount * 2.70):f2}");
                    else if (name == "pineapple")
                        Console.WriteLine($"{(amount * 5.50):f2}");
                    else if (name == "grapes")
                        Console.WriteLine($"{(amount * 3.85):f2}");
                    else
                        Console.WriteLine("error");
                }

                else if (weekDay == "Saturday" || weekDay == "Sunday")
                {
                    if (name == "banana")
                        Console.WriteLine($"{(amount * 2.70):f2}");
                    else if (name == "apple")
                        Console.WriteLine($"{(amount * 1.25):f2}");
                    else if (name == "orange")
                        Console.WriteLine($"{(amount * 0.90):f2}");
                    else if (name == "grapefruit")
                        Console.WriteLine($"{(amount * 1.60):f2}");
                    else if (name == "kiwi")
                        Console.WriteLine($"{(amount * 3.00):f2}");
                    else if (name == "pineapple")
                        Console.WriteLine($"{(amount * 5.60):f2}");
                    else if (name == "grapes")
                        Console.WriteLine($"{(amount * 4.20):f2}");
                    else
                        Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
