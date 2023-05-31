int[] numArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
    int[] condensed = new int[numArray.Length];

bool flag = false;

for (int j = 0; j < condensed.Length - 1; j++)
{
    for (int i = 0; i < numArray.Length - 1; i++)
    {
        condensed[i] = numArray[i] + numArray[i + 1];
        flag = true;
    }
    numArray = condensed;

}
//TIL: you cant "trim down" arrays, maybe move data from another array into a new array that's
//1 index less
if (flag == true)
{

Console.WriteLine(condensed[0]);
}
if (numArray.Length == 1)
{
    Console.WriteLine(numArray[0]);
}
