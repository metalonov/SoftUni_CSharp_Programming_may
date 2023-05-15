using System.Net.Http.Headers;
using System.Threading.Channels;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double credit = 0.0;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    credit += Convert.ToDouble(input);
                }
                else if (input == "Start") 
                {
                    break; 
                }
                else if (input != "0.1" || input != "0.2" || input != "0.5" || input != "1" || input != "2")
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = "";
            }
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input == "Nuts")
                {
                    if (credit - 2.0 >= 0)
                    {
                        credit -= 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "Water") 
                {
                    if (credit - 0.7 >= 0)
                    {
                        credit -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "Crisps")
                {
                    if (credit - 1.5 >= 0)
                    {
                        credit -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "Soda")
                {
                    if (credit - 0.8 >= 0)
                    {
                        credit -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input == "Coke")
                {
                    if (credit - 1.0 >= 0)
                    {
                        credit -= 1.0;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                }
                else if (input != "Nuts" || input != "Water" || input != "Crisps" || input != "Soda" || input != "Coke")
                {
                Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {credit:f2}");
        }
    }
}