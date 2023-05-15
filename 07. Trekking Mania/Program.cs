using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            int climberGroups = int.Parse(Console.ReadLine());
            //дефинираме върховете
            int musala = 0;
            int monblanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            int allPepo = 0;

            for (int i = 0; i < climberGroups; i++)
            {
                //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
                int climbersNum = int.Parse(Console.ReadLine());

                if (climbersNum <= 5) //Група до 5 човека – изкачват Мусала
                {
                    musala += climbersNum;
                }
                else if (climbersNum <= 12) //Група от 6 до 12 човека – изкачват Монблан
                {
                    monblanc += climbersNum;
                }
                else if (climbersNum <= 25) //Група от 13 до 25 човека – изкачват Килиманджаро
                {
                    kilimanjaro += climbersNum;
                }
                else if (climbersNum <= 40) //Група от 26 до 40 човека –  изкачват К2
                {
                    k2 += climbersNum;
                }
                else //(everest >= 41)
                {
                    everest += climbersNum;
                }
                allPepo += climbersNum;

            }
            Console.WriteLine($"{(((double)musala / allPepo)) * 100:f2}%"); //Първи ред - процентът изкачващи Мусала
            Console.WriteLine($"{(((double)monblanc / allPepo)) * 100:f2}%"); //Втори ред – процентът изкачващи Монблан
            Console.WriteLine($"{(((double)kilimanjaro / allPepo)) * 100:f2}%"); //Трети ред – процентът изкачващи Килиманджаро
            Console.WriteLine($"{(((double)k2 / allPepo)) * 100:f2}%"); //Четвърти ред – процентът изкачващи К2
            Console.WriteLine($"{(((double)everest / allPepo)) * 100:f2}%"); //Пети ред – процентът изкачващи Еверест

        }
    }
}
