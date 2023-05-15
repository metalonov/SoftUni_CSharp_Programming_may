using System;

namespace Nubers_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали въведеното от потребителя 
            //число е в интервала[-100, 100] и е различно от 0 и извежда "Yes", ако 
            //отговаря на условията, или "No" ако е извън тях.
            int number = int.Parse(Console.ReadLine());
            if (number >= -100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
