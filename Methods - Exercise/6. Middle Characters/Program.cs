string chars = Console.ReadLine();

FindMiddle(chars);

void FindMiddle(string chars)
{
    if (chars.Length % 2 == 0)
    {
        for (int i = 0; i < chars.Length; i++)
        {
                if (i == chars.Length / 2 || i == chars.Length / 2 - 1)
                {
                    Console.Write(chars[i]);
                }
                else 
                {
                continue; 
                }
        }
    }
    else
    {
        for (int i = 0; i < chars.Length; i++)
        {
            if (i == chars.Length / 2)
            {
                Console.Write(chars[i]);
            }
            else
            {
                continue;
            }
        }
    }
}