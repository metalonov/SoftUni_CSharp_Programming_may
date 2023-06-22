List<int> list1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> list2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> resultList = new List<int> { };


if (list1.Count > list2.Count)
{
    for (int i = 0; i < list2.Count; i++)
    {
    Console.Write($"{list1[i]} ");
    Console.Write($"{list2[i]} ");
    }
    for (int i = list2.Count; i < list1.Count; i++)
    {
    Console.Write($"{list1[i]} ");
    }
}
else //list2 greater
{
    for (int i = 0; i < list1.Count; i++)
    {
        Console.Write($"{list1[i]} ");
        Console.Write($"{list2[i]} ");
    }
    for (int i = list1.Count; i < list2.Count; i++)
    {
        Console.Write($"{list2[i]} ");
    }
}