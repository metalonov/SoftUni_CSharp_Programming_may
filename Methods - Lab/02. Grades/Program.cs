double grade = double.Parse(Console.ReadLine());

WhatInteger(grade);

static void WhatInteger(double input)
{
    if (input <= 6 && input >= 5.50)
    {
        Console.WriteLine("Excellent");
    }
    else if (input <= 5.49 && input >= 4.50)
    {
        Console.WriteLine("Very good");
    }
    else if (input <= 4.49 && input >= 3.50)
    {
        Console.WriteLine("Good");
    }
    else if (input <= 3.49 && input >= 3.00)
    {
        Console.WriteLine("Poor");
    }
    else
    {
        Console.WriteLine("Fail");
    }
}