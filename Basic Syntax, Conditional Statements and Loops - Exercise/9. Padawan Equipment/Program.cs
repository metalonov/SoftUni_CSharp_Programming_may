namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabersPrice = float.Parse(Console.ReadLine());
            double robesPrice = float.Parse(Console.ReadLine());
            double beltsPrice = float.Parse(Console.ReadLine());

            double sabersCountTotal = students + (students * 0.1);
            double sabersPriceTotal = Math.Ceiling(sabersCountTotal) * sabersPrice; 
            double robesPriceTotal = robesPrice * students;
            double freeBelts = students / 6;
            double beltsPriceTotal = beltsPrice * students - beltsPrice * Math.Floor(freeBelts);
            double subTotal = sabersPriceTotal + robesPriceTotal + beltsPriceTotal;
            if (subTotal <= budget) 
            {
            Console.WriteLine($"The money is enough - it would cost {subTotal:f2}lv.");
            }
            else 
            {
            
            Console.WriteLine($"John will need {subTotal - budget:f2}lv more.");
            }
        }
    }
}