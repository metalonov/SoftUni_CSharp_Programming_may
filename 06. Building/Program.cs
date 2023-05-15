using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor > 0; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors) //На последният етаж винаги има апартаменти
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else
                    {
                        if (floor % 2 == 0) //На всеки четен етаж има само офиси (O)
                        {
                            Console.Write($"O{floor}{room} ");
                        }
                        else //На всеки нечетен етаж има само апартаменти (A)
                        {
                            Console.Write($"A{floor}{room} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
