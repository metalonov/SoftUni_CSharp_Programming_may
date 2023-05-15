using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failureLimit = int.Parse(Console.ReadLine());

            int evaluationSum = 0;
            int evaluationCount = 0;
            int failedCount = 0;
            string lastExcercise = string.Empty;

            string input = Console.ReadLine();
            int evaluation;
            while (input != "Enough")
            {
                lastExcercise = input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationSum += evaluation;
                evaluationCount++;
                if (evaluation <= 4) 
                {
                    failedCount++;
                    if (failureLimit == failedCount) 
                    {
                        Console.WriteLine($"You need a break, {failureLimit} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "Enough") //проверяваме дали последния input e ключовата дума за спиране
            {
                Console.WriteLine($"Average score: {(double)evaluationSum / evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExcercise}");
            }
        }
    }
}
