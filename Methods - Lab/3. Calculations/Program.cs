using System.ComponentModel;

string operation = Console.ReadLine();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (operation == "add")
{
    addingNumbers(num1, num2);
}
else if (operation == "multiply")
{
    multiplyNumbers(num1, num2);
}
else if (operation == "subtract")
{
    subtractNumbers(num1, num2);
}
else if (operation == "divide")
{
    divideNumbers(num1, num2);
}


static void addingNumbers (int num1, int num2) 
{
    Console.WriteLine(num1 + num2);
}

static void multiplyNumbers (int num1, int num2)
{
    Console.WriteLine(num1 * num2);

}

static void subtractNumbers(int num1, int num2)
{
    Console.WriteLine(num1 - num2);

}
static void divideNumbers(int num1, int num2)
{
    Console.WriteLine(num1 / num2);

}
