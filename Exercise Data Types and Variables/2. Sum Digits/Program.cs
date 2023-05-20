// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num != 0) 
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine(sum);