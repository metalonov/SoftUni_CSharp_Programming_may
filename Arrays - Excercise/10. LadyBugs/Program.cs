using System.Numerics;

int fieldLenght = int.Parse(Console.ReadLine());
int[] bugIndexesOnTheField = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] field = new int[fieldLenght];

for (int i = 0; i < bugIndexesOnTheField.Length; i++)
{
    int bugIndex = bugIndexesOnTheField[i];
    if (bugIndex>= 0 && bugIndex < field.Length)
    {
        field[bugIndex] = 1;
    }
}

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] argument = command.Split();
    int bugIndex = int.Parse(argument[0]);
    string direction = argument[1];
    int flyLength = int.Parse(argument[2]);

    int landIndex = 0;

    if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
    {
        continue;
    }

    field[bugIndex] = 0;

    if (direction == "right")
    {
        landIndex = bugIndex + flyLength;
        if (landIndex > field.Length - 1)
        {
            continue;
        }
        if (field[landIndex] == 1)
        {
            while (field[landIndex] == 1)
            {
                landIndex += flyLength;
                if (landIndex > field.Length - 1) 
                {
                    break; 
                }
            }
        }

        if (landIndex <= field.Length - 1) 
        {
            field[landIndex] = 1;
        }

    }
    else if (direction == "left") 
    {
        landIndex = bugIndex - flyLength;
        if (landIndex < 0)
        {
            continue;
        }
        if (field[landIndex] == 1)
        {
            while (field[landIndex] == 1)
            {
                landIndex -= flyLength;
                if (landIndex < 0)
                {
                    break;
                }
            }
        }

        if (landIndex >= 0)
        {
            field[landIndex] = 1;
        }

    }

}

Console.WriteLine(string.Join(" ", field));