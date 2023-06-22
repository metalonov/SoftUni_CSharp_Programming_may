using System.Diagnostics.Metrics;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] newArray = new int[input.Length];
int rotation = int.Parse(Console.ReadLine());


if (rotation == input.Length)
{
    newArray = input;
}

else if (rotation > input.Length) 
{
    rotation -= input.Length;
    for (int i = 0; i < input.Length; i++)
    {
        int number = input[rotation + i];
        newArray[i] = number;
        if (i == input.Length - rotation - 1)
        {
            for (int j = 0; j < input.Length - i - 1; j++)
            {
                number = input[j];
                newArray[i + j + 1] = number;
            }
            break;
        }
    }
}

else
{
    for (int i = 0; i < input.Length; i++)
    {
        int number = input[rotation+ i];
        newArray[i] = number;
        if (i == input.Length - rotation - 1)
        {
            for (int j = 0; j < input.Length-i-1; j++)
            {
                number = input[j];
                newArray[i+j+1] = number;
            }
            break;
        }
    }
}


Console.WriteLine(string.Join(" ", newArray));
