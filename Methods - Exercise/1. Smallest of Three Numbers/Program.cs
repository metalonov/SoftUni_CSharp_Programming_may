int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int smallest = IsSmallestNumber(num1, num2, num3);


Console.WriteLine(smallest);

static int IsSmallestNumber (int input1, int input2, int input3) 
{
	int smallest = 0;

	if (input1 > input2 && input2 < input3)
		smallest = input2;
	else if (input2 > input1 && input1 < input3)
		smallest = input1;
	else 
		smallest = input3;

	return smallest;
}