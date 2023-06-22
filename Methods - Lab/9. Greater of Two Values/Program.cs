string input = Console.ReadLine();

if (input == "int")
{
    GetMaxInt(input);
}
else if (input == "char")
{
    GetMaxChar(input);
}
else if (input == "string")
    GetMaxString(input);


static void GetMaxInt(string input) 
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else
        Console.WriteLine(num2);
}
static void GetMaxChar(string input) 
{
    char symb1 = char.Parse(Console.ReadLine());
    char symb2 = char.Parse(Console.ReadLine());
    if (symb1 > symb2)
    {
        Console.WriteLine(symb1);
    }
    else
        Console.WriteLine(symb2);

}
static void GetMaxString(string input)
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();

    if (String.Compare(str1, str2) > 0)
    {
        Console.WriteLine(str1);
    }    else
        Console.WriteLine(str2);

}