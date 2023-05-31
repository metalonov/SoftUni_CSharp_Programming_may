int arrLength = int.Parse(Console.ReadLine());

string[] arrayOne = new string[arrLength];

for (int i = 0; i < arrLength; i++)
{
    arrayOne[i] += Console.ReadLine();
}

for (int i = arrLength - 1; i >= 0; i--)
{
    Console.Write(arrayOne[i] + " ");
}