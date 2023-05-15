using System;
using System.Reflection;
using System.Xml.Linq;

namespace Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
            //1.dog->mammal
            //2.crocodile, tortoise, snake->reptile
            //3.others->unknown
            string animalName = Console.ReadLine();
                switch (animalName) 
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
