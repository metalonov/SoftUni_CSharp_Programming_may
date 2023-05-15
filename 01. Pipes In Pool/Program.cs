using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Басейн с обем V има две тръби от които се пълни.Всяка тръба има определен дебит(литрите вода минаващи през една тръба 
            //за един час).Работникът пуска тръбите едновременно и излиза за N часа. Напишете програма, която изкарва състоянието на
            //басейна, в момента, когато работникът се върне. 

            //инпут
            int v = int.Parse(Console.ReadLine()); //Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала [1…10000].
            int p1 = int.Parse(Console.ReadLine()); //Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала [1…5000].
            int p2 = int.Parse(Console.ReadLine()); //Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала [1…5000].
            double h = double.Parse(Console.ReadLine()); //Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала [1.0…24.00]


            double pipe1 = p1 * h;
            double pipe2 = p2 * h;
            double allWater = pipe1 + pipe2;

            if (v >= allWater)
            {
                //До колко се е запълнил басейна и коя тръба с колко процента е допринесла.
                //"The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."
                Console.WriteLine($"The pool is {(allWater / (double)v) * 100:f2}% full. Pipe 1: {(pipe1 / allWater) * 100:f2}%. Pipe 2: {(pipe2 / allWater) * 100:f2}%.");
            }
            else 
            {
                //Aко басейнът се е препълнил – с колко литра е прелял за даденото време.
                Console.WriteLine($"For {h} hours the pool overflows with {Math.Abs(v - allWater)} liters.");

            }

        }
    }
}
