/*
1 3 5 7 9
exchange 1
max odd
min even
first 2 odd
last 2 even
exchange 3
end
*/
int[] intArrays = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

string input;
while ((input = Console.ReadLine()) != "end")
{

    string[] command = input.Split();
    switch (command[0]) 
    {
        case "exchange":
            int index = int.Parse(command[1]);
            intArrays = ExchangeElements(intArrays, index);
            break;
        case "max":
            string maxType = command[1];
            PrintMaxIndex(intArrays, maxType);
            break;
        case "min":
            string minType = command[1];
            PrintMinIndex(intArrays, minType);
            break;
        case "first":
            string firstType = command[2];
            int firstCount = int.Parse(command[1]);
            PrintFirstElement(intArrays, firstType, firstCount);
            break;
        case "last":
            string lastType = command[2];
            int lastCount = int.Parse(command[1]);
            PrintLastElement(intArrays, lastType, lastCount);
            break;
    }
}
    Console.WriteLine($"[{string.Join(", ", intArrays)}]");

void PrintFirstElement(int[] intArrays, string firstType, int firstCount)
{
    if (firstCount> intArrays.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    string firstElements = "";
    int elementsCount = 0;

    for (int i = 0; i < intArrays.Length; i++)
    {
        if (IsOddOrEven(firstType, intArrays[i]))
        {
            firstElements += $"{intArrays[i]}, ";
            elementsCount++;
            if (elementsCount >= firstCount)
            {
                break;
            }
        }
    }
    Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
}
void PrintLastElement(int[] intArrays, string lastType, int lastCount)
{
    if (lastCount > intArrays.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    string lastElements = "";
    int elementsCount = 0;

    for (int i = intArrays.Length - 1; i >= 0; i--)
    {
        if (IsOddOrEven(lastType, intArrays[i]))
        {
            lastElements = $"{intArrays[i]}, " + lastElements;
            elementsCount++;
            if (elementsCount >= lastCount)
            {
                break;
            }
        }
    }
    Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
}

void PrintMinIndex(int[] intArrays, string minType)
{
    int minIndex = -1;
    int minNumber = int.MaxValue;
    for (int i = 0; i < intArrays.Length; i++)
    {
        int number = intArrays[i];
        if (IsOddOrEven(minType, number))
        {
            if (number <= minNumber)
            {
                minNumber = number;
                minIndex = i;
            }
        }
    }
    NoMatches(minIndex);
}

void PrintMaxIndex(int[] intArrays, string mxType)
{
    int maxIndex = -1;
    int maxNumber = int.MinValue;
    for (int i = 0; i < intArrays.Length; i++)
    {
        int number = intArrays[i];
        if (IsOddOrEven(mxType, number))
        {
            if (number >= maxNumber)
            {
                maxNumber = number;
                maxIndex = i;
            }
        }
    }
    NoMatches(maxIndex);
}

static bool IsOddOrEven(string mxType, int input)
{
    return (mxType == "even" && input % 2 == 0) 
        ||(mxType == "odd" && input % 2 != 0);
}

static int[] ExchangeElements(int[] input, int index)
{
    int[] output = new int[input.Length];
    if (CheckForRange(input, index) == true)
    {
        Console.WriteLine("Invalid index");
        return input;
    }
    int changedArrIndex = 0;

        for (int i = index + 1; i < input.Length; i++)
        {
            output[changedArrIndex++] = input[i];
        }
        for (int i = 0; i <= index; i++)
        {
            output[changedArrIndex++] = input[i];
        }
    return output;
}

static bool CheckForRange(int[] array, int input)
{
    return input < 0 || input >= array.Length;
}

static void NoMatches(int maxIndex)
{
    if (maxIndex != -1)
    {
        Console.WriteLine(maxIndex);
    }
    else
        Console.WriteLine("No matches");
}