using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //вход: Име на актьора - текст (string)
            string name = Console.ReadLine();
            //първоначални точки за актьора - реално число в интервала [2.0... 450.5] (double!)
            double startingScore = double.Parse(Console.ReadLine());
            //Брой оценяващи n - цяло число в интервала[1… 20] (integer! for loop)
            int juryCount = int.Parse(Console.ReadLine());
            double score = 0;

            for (int i = 1; i <= juryCount; i++)
            {
                //във for loop-a Име на оценяващия - текст 
                string juryName = Console.ReadLine();
                //Точки от оценяващия - реално число в интервала [1.0... 50.0] (double!)
                double scoreAward = double.Parse(Console.ReadLine());
                //дължината на името на оценяващия умножено по точките, делено на две
                score = juryName.Length * scoreAward / 2;
                startingScore += score;

                //4. Ако резултатът в някой момент надхвърли 1250.5 (break)
                //изход: if-else
                if (startingScore > 1250.5)
                {
                    //програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.
                    //форматиране: до първата цифра след десетичния(:f1)
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {(startingScore):f1}!");
                    break;
                }
            }
            if (startingScore <= 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - startingScore:f1} more!");
            }

        }
    }
}
