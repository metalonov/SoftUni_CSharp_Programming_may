using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) 
{
    if (IsTopNumber(i)) 
    {
        Console.WriteLine(i);
    }
}

static bool IsTopNumber(int input)
{
    if (IsDivisibleByEight(input) && HasOddNumber(input))
        return true;
    return false;
}

static bool HasOddNumber(int input)
{

    while (input > 0)
    {
        int lastDigit = input % 10;
        if (input % 2 != 0)
            return true;
        input /= 10;
    }
    return false;
}

static bool IsDivisibleByEight(int input)
{
    int sum = 0;

    while (input > 0) 
    {
        sum += input % 10;
        input /= 10;
    }
    if (sum % 8 == 0)
    {
    return true;
    }
    return false;
}