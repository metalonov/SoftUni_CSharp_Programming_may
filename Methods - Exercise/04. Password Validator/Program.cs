using System.ComponentModel.Design;

string password = Console.ReadLine();

CharacterLength(password);
OnlyLettersDigitis(password);
TwoDigits(password);



static void TwoDigits(string input)
{
        int counter = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int temp = (int)input[i];
            
        if (temp >= 48 && temp <= 57)
        {
            counter++;
        }
    }
    if (counter<2)
    {
    Console.WriteLine("Password must have at least 2 digits");
    return;
    }
    Console.WriteLine("Password is valid");
}
static bool OnlyLettersDigitis(string input) 
{

    for (int i = 0; i < input.Length; i++)//this takes the string array indexes
    {
        int temp = (int)input[i];

        if (temp < 48||temp>57&&temp<65||temp>90&&temp<97||temp>122) //no digits
        {
            Console.WriteLine("Password must consist only of letters and digits");
            return false;
        }

    }
            return true;
}

static void CharacterLength(string input) 
{
    input = "";
    if (input.Length < 6 || input.Length > 10 )
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
}