string[] input = Console.ReadLine().Split(' ');

for (int i = 0; i < input.Length / 2; i++)
{
    string firstElement = input[i];
    string lastElement = input[input.Length - i - 1];

    input[i] = lastElement;
    input[input.Length - i - 1] = firstElement;
}
for (int i = 0; i < input.Length; i++)
{
    Console.Write(input[i] + " ");
}