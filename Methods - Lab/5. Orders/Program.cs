string product = Console.ReadLine();
double quantity = int.Parse(Console.ReadLine());

calculation(product, quantity);

static void calculation(string inputProduct, double quantityValue)
{
    if (inputProduct == "coffee")
    {
        Console.WriteLine($"{ quantityValue * 1.50:f2}");
    }
    else if (inputProduct == "water")
    {
        Console.WriteLine($"{quantityValue * 1.00:f2}");
    }
    else if (inputProduct == "coke")
    {
        Console.WriteLine($"{quantityValue * 1.40:f2}");
    }
    else if (inputProduct == "snacks") 
    {
        Console.WriteLine($"{quantityValue * 2.00:f2}");
    }
}