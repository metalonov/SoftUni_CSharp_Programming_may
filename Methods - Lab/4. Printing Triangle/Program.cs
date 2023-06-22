
int input = int.Parse(Console.ReadLine());


for (int i = 1; i < input; i++)
{
    PrintLine(1, i);
}

for (int i = 0; i <= input; i++)
{
    PrintLine(1, input - i);
}


static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");

    }
    Console.WriteLine();
}

