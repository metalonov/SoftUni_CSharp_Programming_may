double numBase = double.Parse(Console.ReadLine());
double numPower = double.Parse(Console.ReadLine());

Console.WriteLine(MathPower(numBase, numPower));

static double MathPower(double numBase, double numPow)
{
    double sum = 1;
    for (int i = 0; i < numPow; i++)
    {
        sum *= numBase;

    }
    return sum;

}