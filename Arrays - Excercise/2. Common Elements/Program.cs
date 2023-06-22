string[] line1 = Console.ReadLine().Split();
string[] line2 = Console.ReadLine().Split();

for (int i = 0; i < line2.Length; i++)
{
	for (int j = 0; j < line1.Length; j++)
	{
		if (line2[i] == line1[j])
		{
			Console.Write(line1[j] + " ");
		}
	}
}
