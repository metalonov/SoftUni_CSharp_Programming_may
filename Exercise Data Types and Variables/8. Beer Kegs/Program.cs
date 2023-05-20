// See https://aka.ms/new-console-template for more information

//inputs
int kegsNum = int.Parse(Console.ReadLine());
string biggestKeg = "";
double maxVolume = 0.0;

//work
for (int i = 0; i < kegsNum; i++)
{

string model = Console.ReadLine();
double radius = double.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
	double volume = Math.PI * (radius * radius) * height;
	if (volume > maxVolume)
	{
		maxVolume = volume;
		biggestKeg = model;
	}
}

//output
Console.WriteLine(biggestKeg);
