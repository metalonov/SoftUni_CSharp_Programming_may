using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input: брой стъпки изминати и вход текст
            int totalSteps = 0;
            string input;

            //цикъл докато не постигне цел
            while (totalSteps < 10000)
            {
                input = Console.ReadLine();
                //проверяване на входа дали е бр. стъпки или текст(Going home)
                //ako e Going home > четем и добавяме към останалите> break

                if (input == "Going home") 
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                //ако не: проверка дали входа е число и добавяме към общия брой
                totalSteps += int.Parse(input);
            }
            //излизане от цикъла, проверка за цел
            if (totalSteps >= 10000)    
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            //ако не
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
