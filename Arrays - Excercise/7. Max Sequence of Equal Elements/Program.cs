string[] sequence = Console.ReadLine().Split();

int leftmostLongestSequence = 0;
string longestSequenceDigit = "";

for (int i = 0; i < sequence.Length; i++)
{
    int sequenceCount = 0;
    for (int j = i; j < sequence.Length; j++)
    {
        if (sequence[i] == sequence[j])
        {
            sequenceCount++;
            if (leftmostLongestSequence < sequenceCount)
            {
                longestSequenceDigit = sequence[i];
                leftmostLongestSequence = sequenceCount;
            }
        }
        else 
        {
            break;
        }
    }
}

for (int i = 0; i < leftmostLongestSequence; i++)
{
    Console.Write($"{longestSequenceDigit} ");
}
