using System.Runtime.InteropServices;

char initialChar = char.Parse(Console.ReadLine());
char finalChar = char.Parse(Console.ReadLine());

CharSuccession(initialChar, finalChar);

static void CharSuccession(int charStart, int charEnd)
{
	if (charStart>charEnd)
	{
        for (int i = charEnd + 1; i < charStart; i++)
        {
            Console.Write($"{(char)i} ");
        }
    }
	else
	{
	for (int i = charStart+1; i < charEnd; i++)
	{
        Console.Write($"{(char)i} ");
    }

	}
}