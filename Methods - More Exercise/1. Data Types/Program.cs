string type = Console.ReadLine();

WhatType(type);
static void NewMethod2(string? type)
{
    if (type == "string")
    {
        string word = Console.ReadLine();
        Console.WriteLine("$" + word + "$");
    }
}

static void NewMethod1(string? type)
{
    if (type == "real")
    {
        double dbl = double.Parse(Console.ReadLine());
        Console.WriteLine($"{dbl * 1.5:F2}");
    }
}

static void NewMethod(string? type)
{
    if (type == "int")
    {
        int integ = int.Parse(Console.ReadLine());
        Console.WriteLine(integ * 2);
    }
}
static void WhatType(string? type)
{
    NewMethod(type);
    NewMethod1(type);
    NewMethod2(type);
}
