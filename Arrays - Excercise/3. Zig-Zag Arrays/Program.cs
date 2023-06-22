using System.Diagnostics.Metrics;

int length = int.Parse(Console.ReadLine());
string[] array1 = new string[length];
string[] array2 = new string[length];

for (int i = 0; i < length; i++)
{
    if (i%2==0)
    {
    string[] input = Console.ReadLine().Split();
        array1[i] = input[0];
        array2[i] = input[1];
    }
    else
    {
        string[] input = Console.ReadLine().Split();
        array1[i] = input[1];
        array2[i] = input[0];
    }
}

Console.Write(string.Join(" ", array1));
Console.WriteLine();
Console.Write(string.Join(" ", array2));

