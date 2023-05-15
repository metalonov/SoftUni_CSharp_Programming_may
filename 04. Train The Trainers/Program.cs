using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //броят на хората в журито n - цяло число в интервала [1…20]
            string input;
            string presentationName = "";
            int presentationCounter = 0;
            double gradeSum = 0;
            double gradeAverage = 0.0;
            while ((input = Console.ReadLine()) != "Finish")
            {
                gradeSum = 0;
                presentationName = input;
                for (int i = 1; i <= n; i++)
                {
                    gradeSum+= double.Parse(Console.ReadLine());
                }
                gradeSum /= n;
                Console.WriteLine($"{presentationName} - {gradeSum:f2}.");
                presentationCounter++;
                gradeAverage += gradeSum;
            }
                Console.WriteLine($"Student's final assessment is {gradeAverage/presentationCounter:f2}.");
        }
    }
}
