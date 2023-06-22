
List<int> numList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> numListCopy = numList;

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split(' ');
    switch (arguments[0])
    {
        case "Contains":
            int number = int.Parse(arguments[1]);
            if (numList.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;
        case "PrintEven":
            PrintEven(numList);
            break;
        case "PrintOdd":
            PrintOdd(numList);
            break;
        case "GetSum":
            Console.WriteLine(numList.Sum()); 
            break;
        case "Filter":
            string operators = arguments[1];
            number = int.Parse(arguments[2]);
            FilterMethod(numList, operators, number);
            break;
    }
}

if (numListCopy != numList)
{
    Console.WriteLine(string.Join(" ", numList));
}

static void FilterMethod(List<int> input, string operators, int conditionNum)

{
    switch (operators) 
    {
        case "<":
            for (int i = 0; i < input.Count; i++)
            {
                int temp = input[i];
                if (temp < conditionNum)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
            break;
        case ">":
            for (int i = 0; i < input.Count; i++)
            {
                int temp = input[i];
                if (temp > conditionNum)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
            break;
        case "<=":
            for (int i = 0; i < input.Count; i++)
            {
                int temp = input[i];
                if (temp <= conditionNum)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
            break;
        case ">=":
            for (int i = 0; i < input.Count; i++)
            {
                int temp = input[i];
                if (temp >= conditionNum)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
            break;
    }
        
        
        }

static void PrintEven(List<int> input) 
{
    for (int i = 0; i < input.Count; i++)
    {
        if (input[i] % 2 == 0)
        {

            Console.Write($"{input[i]} ");
        }
        else
            continue;
    }
    Console.WriteLine();
}

static void PrintOdd(List<int> input) 
{
    for (int i = 0; i < input.Count; i++)
    {
        if (input[i] % 2 != 0)
        {

            Console.Write($"{input[i]} ");
        }
        else
            continue;
    }
    Console.WriteLine();
}