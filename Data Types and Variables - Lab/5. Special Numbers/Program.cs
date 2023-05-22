int input = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= input; i++)
{
    int num = i;
    bool flag = false;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    if (sum > 0 && (sum == 5 || sum == 7 || sum == 11))
    {
        flag = true;
    }
    sum = 0;
    Console.WriteLine($"{i} -> {flag}");
}