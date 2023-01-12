using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegeterianMenu = double.Parse(Console.ReadLine());
            double totalChicken = chickenMenu * 10.35;
            double totalFish = fishMenu * 12.40;
            double totalVegetarian = vegeterianMenu * 8.15;
            double desert = (totalChicken + totalFish + totalVegetarian) * 0.2;
            Console.WriteLine(totalChicken + totalFish + totalVegetarian + desert + 2.5);
        }
    }
}
