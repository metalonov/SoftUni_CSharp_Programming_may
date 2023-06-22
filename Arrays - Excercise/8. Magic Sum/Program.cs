int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int targetSum = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++) 
{
    for (int j = i+1; j < numbers.Length; j++) 
    {
        if (numbers[i] + numbers[j] == targetSum)
        {
            Console.WriteLine($"{numbers[i]} {numbers[j]}");
            break;
        }
    }
}