using System;
using System.Drawing;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if (shape == "square")
            { 
                double sqSide = double.Parse(Console.ReadLine());
                Console.WriteLine(sqSide * sqSide);
            }
            if (shape == "rectangle")
            {
                double recSide1 = double.Parse(Console.ReadLine());
                double recSide2 = double.Parse(Console.ReadLine());
                Console.WriteLine(recSide1 * recSide2);
            }
            if (shape == "circle")
            {
                double cirDiam = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * cirDiam * cirDiam);
            }
            if (shape == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side2 / 2);
            }
        }
    }
}
