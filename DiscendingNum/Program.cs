using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        int temp;

        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // Sort the numbers in descending order
        if (num1 < num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        if (num2 < num3)
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }

        if (num1 < num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine("The numbers in descending order are: ");
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}
