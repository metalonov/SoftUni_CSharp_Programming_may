using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int mostGoals = 0;
            string mvp = "";
            bool hattrick = false;
            while ((input = Console.ReadLine()) != "END")
            {
                int input2 = int.Parse(Console.ReadLine());
                if (input2 > mostGoals)
                {
                    mostGoals = input2;
                    mvp = input;
                    if (input2 >= 3)
                    {
                        hattrick = true;
                    }
                }
                if (mostGoals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{mvp} is the best player!");
            if (hattrick) 
            {
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostGoals} goals.");
            }
        }
    }
}
