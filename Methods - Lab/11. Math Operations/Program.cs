using System.Runtime.CompilerServices;

double num1 = double.Parse(Console.ReadLine());
string @operator = Console.ReadLine();
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine(Calculator(num1, @operator, num2));

static double Calculator (double num1, string @operator, double num2) 
{
    double result = 0;

    switch (@operator) 
    {
        case "+":
        result = num1 + num2;
        break;
        case "-":
        result = num1 - num2;
        break;
        case "*":
        result = num1 * num2;
        break;
        case "/":
        result = num1 / num2;
        break;
    }
    return result;
}