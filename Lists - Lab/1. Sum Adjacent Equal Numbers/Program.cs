﻿

List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();



for (int i = 0; i < numbers.Count - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        numbers[i] += numbers[i + 1];
        numbers.RemoveAt(i + 1);
        i = -1;
    }
}

for (int i = 0; i < numbers.Count; i++)
{
    Console.Write($"{numbers[i]} ");
}
