using System;
using System.Diagnostics;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string word;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "n")
                {
                    int letterNcount = 1;
                    continue;
                }
                else if (input == "o")
                {
                    int letterOcount = 1;
                }
                else if (input == "c")
                {
                    int letterCcount = 1;
                }
                else
                {
                    word += input;
                }
            }

        }
    }
}
