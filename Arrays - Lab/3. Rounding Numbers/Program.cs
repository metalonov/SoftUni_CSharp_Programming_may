﻿var input = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();


for (int i = 0; i < input.Length; i++) 
{
    Console.WriteLine($"{input[i]} => {(int)Math.Round(input[i], MidpointRounding.AwayFromZero)}");
}

