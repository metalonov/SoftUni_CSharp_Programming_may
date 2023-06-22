double sideOne = double.Parse(Console.ReadLine());
double sideTwo = double.Parse(Console.ReadLine());

Console.WriteLine(CalculateArea(sideOne, sideTwo));

static double CalculateArea(double sideOne, double sideTwo)
{
    return sideOne*sideTwo;
}