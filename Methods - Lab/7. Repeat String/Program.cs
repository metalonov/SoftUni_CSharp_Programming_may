string str = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    RepeatStr(str);
}

static void RepeatStr(string str)
{
        Console.Write(str);
}