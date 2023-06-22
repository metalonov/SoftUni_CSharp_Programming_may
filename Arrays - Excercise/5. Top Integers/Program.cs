using System;

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < input.Length; i++)
{
    bool isTheBiggest = true;
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] <= input[j])
        {
            isTheBiggest = false;
            break;
        }

    }
    if (isTheBiggest)
    {
        Console.Write(input[i] + " ");
    }
}