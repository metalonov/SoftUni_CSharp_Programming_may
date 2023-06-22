int inputNum = int.Parse(Console.ReadLine());
inputNum = Math.Abs(inputNum);


Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(inputNum), GetSumOfODdDigits(inputNum)));
static int GetMultipleOfEvenAndOdds(int input, int input2)
{

    return input * input2;
}
static int GetSumOfEvenDigits(int input)
{
    int sum = 0;
    while (input != 0)
    {
        if (input % 2 == 0)
        {
            sum += input % 10;
            input /= 10;
        }
        else
        input /= 10;
    }
    return sum;
}

static int GetSumOfODdDigits(int input)
{
    int sum = 0;
    while (input != 0)
    {
        if (input % 2 != 0)
        {
            sum += input % 10;
            input /= 10;

        }
        else
            input /= 10;
    }
    return sum;
}
