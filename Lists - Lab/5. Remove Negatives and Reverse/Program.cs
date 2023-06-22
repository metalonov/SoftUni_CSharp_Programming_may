List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

input.Reverse();
input.RemoveAll(n => n < 0);


if (input.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", input));
}


