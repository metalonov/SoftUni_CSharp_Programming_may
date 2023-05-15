using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете име на продукт, въведено от потребителя,
            string name = Console.ReadLine();
            switch (name) 
            {
                case (string)"banana":
                case (string)"apple":
                case (string)"kiwi":
                case (string)"cherry":
                case (string)"lemon":
                case (string)"grapes":
                    Console.WriteLine("fruit");
                    break;
                case (string)"tomato":
                case (string)"cucumber":
                case (string)"pepper":
                case (string)"carrot":
                    Console.WriteLine("vegetable");
                    break;
                default: 
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
