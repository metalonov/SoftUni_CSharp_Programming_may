using System;

namespace RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the shape's first side measurements ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = a * b;
            Console.WriteLine(area);
        }
    }
}
