using System.Runtime.InteropServices;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            int smth = 0;

            for (int i = userName.Length - 1; i >= 0; i--) 
            {
                password += userName[i];
            }
            for (int i = 0; i <= 3; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                if (smth == 3)
                {
                Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else if (input != password)
                {
                Console.WriteLine("Incorrect password. Try again.");
                    smth++;
                }
            }
        }
    }
}