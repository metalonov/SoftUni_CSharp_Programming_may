string[] weekDays = new string[7];

weekDays[0] = "Monday";
weekDays[1] = "Tuesday";
weekDays[2] = "Wednesday";
weekDays[3] = "Thursday";
weekDays[4] = "Friday";
weekDays[5] = "Saturday";
weekDays[6] = "Sunday";

string input = Console.ReadLine();

switch (input)
{
	case "1":
		Console.WriteLine(weekDays[0]);
		break;
	case "2":
		Console.WriteLine(weekDays[1]);
		break;
	case "3":
		Console.WriteLine(weekDays[2]);
		break;
	case "4":
		Console.WriteLine(weekDays[3]);
		break;
	case "5":
		Console.WriteLine(weekDays[4]);
		break;
	case "6":
		Console.WriteLine(weekDays[5]);
		break;
	case "7":
		Console.WriteLine(weekDays[6]);
		break;
    default:
		Console.WriteLine("Invalid day!");
        break;
}