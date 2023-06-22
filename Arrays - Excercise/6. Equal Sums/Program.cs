int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int matchingIndex = 0;
bool flag = false;

for (int i = 0; i < input.Length; i++)
{
    int sumRight = 0;
    int sumLeft = 0;
    int selectedNum = input[i];
    for (int j = i + 1; j < input.Length; j++) //sum stuff to the right
    {
             
        sumRight += input[j];
    }
    for (int k = i - 1; k >= 0; k--) //sums stuff to the left
    {
        sumLeft += input[k];
    }
    if (sumLeft == sumRight) //compares the two
    {
        matchingIndex = i;
        flag = true;
        break;
    }
}

    if (flag == true) //output conditions
    {
            Console.WriteLine(matchingIndex);
    }
    else
    {
        Console.WriteLine("no");
    }