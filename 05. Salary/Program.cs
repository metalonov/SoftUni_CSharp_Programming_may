using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string tabName;

            for (int i = 1; i <= tabs; i++)
            {
                tabName = Console.ReadLine();

                    if (tabName == "Facebook")
                    {
                        salary -= 150;
                    }
                    else if (tabName == "Instagram")
                    {
                        salary -= 100;
                    }
                    else if (tabName == "Reddit")
                    {
                        salary -= 50;
                    }
                    if (salary <= 0) 
                    {
                    Console.WriteLine("You have lost your salary.");
                    break;
                    }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
