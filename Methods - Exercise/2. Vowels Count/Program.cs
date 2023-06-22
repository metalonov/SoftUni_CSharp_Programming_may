string input = Console.ReadLine();

int numberOfVowels = 0;

Console.WriteLine(VowelCounter(input, numberOfVowels));

static int VowelCounter (string input, int counter)

{
	char[] chars = input.ToCharArray ();
	counter = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (chars[i] == 'a' || chars[i] == 'i'||chars[i] == 'e'|| chars[i] == 'o' || chars[i] == 'u' || chars[i] == 'A'
            || chars[i] == 'I' || chars[i] == 'E' || chars[i] == 'O' || chars[i] == 'U')
        {
			counter++;
		}
	}
	return counter;
}