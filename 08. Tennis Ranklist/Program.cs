using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentLoop = int.Parse(Console.ReadLine()); //Брой турнири, в които е участвал – цяло число в интервала [1…20] 
            int startingScore = int.Parse(Console.ReadLine()); //Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            int tournamentsWon = 0;
            int scoreWon = 0;

            for (int i = 1; i <= tournamentLoop; i++)
            {
                string finishRank = Console.ReadLine(); //Достигнат етап от турнира – текст – "W", "F" или "SF"
                if (finishRank == "W") //W - ако е победител получава 2000 точки
                {
                    scoreWon += 2000;
                    tournamentsWon++;
                }
                else if (finishRank == "F") //F - ако е финалист получава 1200 точки
                {
                    scoreWon += 1200;
                }
                else //SF - ако е полуфиналист получава 720 точки
                {
                    scoreWon += 720;
                }
            }

            Console.WriteLine($"Final points: {startingScore + scoreWon}"); //Final points: {брой точки след изиграните турнири}
            Console.WriteLine($"Average points: {scoreWon / tournamentLoop}"); //"Average points: {средно колко точки печели за турнир}"
            Console.WriteLine($"{((double)tournamentsWon / tournamentLoop)*100:f2}%"); //"{процент спечелени турнири}%"
        }
    }
}
