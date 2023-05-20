using System.Data.SqlTypes;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double kbdPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int kbdCount = 0;
            int displayCount = 0;
            bool sameGame = false;
            bool sameGameTwo = false;

            //for loop based on lostGamesCount

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                    sameGame = true;
                }
                if (i % 3 == 0) 
                {
                    mouseCount++;
                    sameGameTwo = true;
                }
                if (sameGame == true && sameGameTwo == true)
                {
                    kbdCount++;
                    if (kbdCount > 0 && kbdCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
                sameGame = false;
                sameGameTwo = false;
            }
            double gearCost = (headsetPrice * (double)headsetCount) + (mousePrice * (double)mouseCount) + ((double)kbdCount * kbdPrice) + ((double)displayCount * displayPrice);
            Console.WriteLine($"Rage expenses: {gearCost:f2} lv.");
        }
    }
}