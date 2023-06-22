int n = int.Parse(Console.ReadLine());
int passengers = 0;
int[] wagons = new int[n];

for (int i = 0; i < n; i++) 
    {
    passengers = int.Parse(Console.ReadLine());
    wagons[i] = passengers;
    }

    Console.WriteLine(string.Join(" ", wagons));
    Console.WriteLine(wagons.Sum());
    