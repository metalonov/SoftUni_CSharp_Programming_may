int input = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= input; i++)
{
    bool flag = false;
    int num = i;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    flag = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine($"{i} -> {flag}");
    sum = 0;
}