// See https://aka.ms/new-console-template for more information
using System.Numerics;

int n = int.Parse(Console.ReadLine()); //the number of snowballs

BigInteger snowballValue = 0;
BigInteger bestValue = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;

for (int i = 0; i < n; i++) 
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

        snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

    if (snowballValue>bestValue)
    {
        bestSnow = snowballSnow;
        bestTime = snowballTime;
        bestQuality = snowballQuality;
        bestValue = snowballValue;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");