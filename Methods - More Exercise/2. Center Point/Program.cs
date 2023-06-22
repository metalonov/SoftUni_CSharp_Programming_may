double[] coords = new double[4];

for (int i = 0; i < 4; i++)
{
    double number = double.Parse(Console.ReadLine());
    coords[i] = number;
}

FindingDistance(coords);

static void FindingDistance(double[] coords)
{
    double distance1 = Math.Sqrt(coords[0] * coords[0] + coords[1] * coords[1]);
    double distance2 = Math.Sqrt(coords[2] * coords[2] + coords[3] * coords[3]);
    if (distance1 > distance2)
    {
        Console.WriteLine($"({coords[2]}, {coords[3]})");
    }
    else if (distance1 < distance2)
    {
        Console.WriteLine($"({coords[0]}, {coords[1]})");
    }
    else 
    {
        Console.WriteLine($"({coords[2]}, {coords[3]})");
    }
}