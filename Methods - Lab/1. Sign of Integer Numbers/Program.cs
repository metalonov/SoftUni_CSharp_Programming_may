int input = int.Parse(Console.ReadLine());

WhatInteger(input);

static void WhatInteger (int input) 
{
    if (input < 0)
    {
        Console.WriteLine($"The number {input} is negative.");
    }
    else if (input > 0)
    {
        Console.WriteLine($"The number {input} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {input} is zero.");
    }
}