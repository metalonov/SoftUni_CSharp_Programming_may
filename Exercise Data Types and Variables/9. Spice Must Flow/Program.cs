// See https://aka.ms/new-console-template for more information
int yield = int.Parse(Console.ReadLine());
int days = 0;
int spice = 0;

while (yield >= 100) 
{
    spice += yield;
    spice -= 26; //mining crew consumes 26 spices every day at the end of their shift
    days++;
    yield -= 10; //  After it has been mined for a day the yield drops by 10
    if (yield <= 99)
    {

        spice -= 26; // additional 26 after the mine has been exhausted
    }
}

//output
Console.WriteLine(days);
Console.WriteLine(spice);
