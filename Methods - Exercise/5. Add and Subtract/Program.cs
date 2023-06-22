
int input = 0;
int result = 0;
for (int i = 0; i < 2; i++)
{
    input = int.Parse(Console.ReadLine());
    result += AddTheFirstTwoNums(input);

}

SubtractThirdFromSumOfTwo(result, int.Parse(Console.ReadLine()));

static int AddTheFirstTwoNums(int num) 
{
    int sum =+ num;
    return sum;
}
static void SubtractThirdFromSumOfTwo (int result, int num3) 
{
    result -= num3;
    Console.WriteLine(result);
}