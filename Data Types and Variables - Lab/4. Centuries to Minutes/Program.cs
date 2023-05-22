int centuries = int.Parse(Console.ReadLine());

double years = centuries * 100;
double days = years * 365.2422;
int hours = (int)days * 24;
int minutes = (int)hours * 60;   

Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");