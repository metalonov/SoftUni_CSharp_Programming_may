using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); //Първи ред – брой дни – цяло число в интервал [1…5000]
            int food = int.Parse(Console.ReadLine()); //Втори ред – оставена храна в килограми – цяло число в интервал [0…100000]
            double dog = double.Parse(Console.ReadLine()); //Трети ред – храна на ден за кучето в килограми – реално число в интервал [0.00…100.00]
            double cat = double.Parse(Console.ReadLine()); //Четвърти ред – храна на ден за котката в килограми– реално число в интервал [0.00…100.00]
            double turtle = double.Parse(Console.ReadLine()); //Пети ред – храна на ден за костенурката в грамове – реално число в интервал [0.00…10000.00]

            double upkeepFood = (dog + cat + (turtle/1000)) * days;

            if (upkeepFood <= food) //Ако оставената храна Е достатъчна:
            {
                Console.WriteLine($"{Math.Floor(food - upkeepFood)} kilos of food left.");    
            }
            else 
            {
                Console.WriteLine($"{Math.Ceiling(upkeepFood - food)} more kilos of food are needed.");
            }
        }
    }
}
