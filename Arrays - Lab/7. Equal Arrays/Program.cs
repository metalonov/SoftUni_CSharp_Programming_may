using System;

int[] arrayOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] arrayTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();


    for (int i = 0; i < arrayOne.Length; i++)
    {
    if (arrayOne[i] != arrayTwo[i])
        {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
        }
        else if (i == arrayOne.Length - 1) 
        { 
            Console.WriteLine($"Arrays are identical. Sum: {arrayOne.Sum()}");
        }
    }
