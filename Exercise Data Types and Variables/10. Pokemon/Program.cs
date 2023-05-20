using System.ComponentModel.Design;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());  //poke power the Pokemon has, N – an integer.
            int distance = int.Parse(Console.ReadLine()); //distance between the poke targets, M – an integer
            int exhaustionFactor = int.Parse(Console.ReadLine());  //the exhaustionFactor Y – an integer
            int targetCount = 0;
            int halfPower = pokePower/2;

            while (pokePower >= distance) //until N becomes less than M
            {
                            //start subtracting M
                            //from N 
                pokePower -= distance;
                if (pokePower == halfPower && exhaustionFactor != 0) //IF N becomes equal to EXACTLY 50 % of its original value
                {
                    pokePower /= exhaustionFactor; //you must divide N by Y
                }
                targetCount++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
