using System;

namespace _04._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentNum = int.Parse(Console.ReadLine());
            double grade = 0.0;
            double gradeSum = 0.0;
            int weakCounter = 0;
            int averageCounter = 0;
            int verygoodCounter  = 0;
            int exellentCounter = 0;
            for (int i = studentNum; 0 < i; i--)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade < 3.00)
                {
                    gradeSum += grade;
                    weakCounter++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    gradeSum += grade;
                    averageCounter++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    gradeSum += grade;
                    verygoodCounter++;
                }
                else if (grade >= 5) 
                {
                    gradeSum += grade;
                    exellentCounter++;
                }
            }
            Console.WriteLine($"Top students: {(double)exellentCounter /studentNum * 100:f2}%"); //процент студенти с успех 5.00 или повече
            Console.WriteLine($"Between 4.00 and 4.99: {((double)verygoodCounter / studentNum) * 100:f2}%"); //между 4.00 и 4.99 включително
            Console.WriteLine($"Between 3.00 and 3.99: {((double)averageCounter / studentNum) * 100:f2}%"); //между 3.00 и 3.99 включително
            Console.WriteLine($"Fail: {((double)weakCounter / studentNum) * 100:f2}%"); //по-малко от 3.00
            Console.WriteLine($"Average: {(double)gradeSum / studentNum:f2}"); //среден успех
        }
    }
}
