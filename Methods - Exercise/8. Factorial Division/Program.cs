long firstNum = long.Parse(Console.ReadLine());
long secondNum = long.Parse(Console.ReadLine());
double result = Factorial(firstNum) / Factorial(secondNum);
Console.WriteLine($"{result:F2}");

static double Factorial(long number)
{
    double result = number;
	for (long i = 1; i < number; i++)
	{
		result *= i;
	}
	return result;
}