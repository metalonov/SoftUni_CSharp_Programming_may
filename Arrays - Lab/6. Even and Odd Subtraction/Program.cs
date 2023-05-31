int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int currentEven = 0;
int currentOdd = 0;


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) 
    {
        currentEven += numbers[i]; 
    }
    else
    {
        currentOdd += numbers[i];
    }
}
Console.WriteLine(currentEven-currentOdd);