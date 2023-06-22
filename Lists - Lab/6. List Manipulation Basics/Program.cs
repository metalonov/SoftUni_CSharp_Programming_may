
List<int> numList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split(' ');
    switch (arguments[0])
    {
        case "Add":
            int number = int.Parse(arguments[1]);
            numList.Add(number);
            break;
        case "Remove":
            number = int.Parse(arguments[1]);
            numList.Remove(number);
            break;
        case "RemoveAt":
            int index = int.Parse(arguments[1]);
            numList.RemoveAt(index);
            break;
        case "Insert":
            number = int.Parse(arguments[1]);
            index = int.Parse(arguments[2]);
            numList.Insert(index, number);
            break;
    }
}
Console.WriteLine(string.Join(" ", numList));

/*
4 19 2 53 6 43
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end
*/

/*
23 1 456 63 32 87 9 32
Remove 5
Add 1
Insert 14 2
RemoveAt 3
Add 34
end
*/