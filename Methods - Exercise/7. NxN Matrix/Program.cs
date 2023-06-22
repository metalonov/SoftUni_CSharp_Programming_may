int n = int.Parse(Console.ReadLine());

Console.WriteLine(CreateStringMatrix(n));

static string CreateStringMatrix(int n) 
{
    string result = "";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			result += $"{n} ";
		}
		result += "\n";
	}
	return result;
}