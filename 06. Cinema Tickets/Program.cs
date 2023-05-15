using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie;
            string input;
            int freeSeats;
            int totalTicketsSold = 0;
            int movieTicketsSold = 0;
            bool flag = false;

            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;


            while ((input = Console.ReadLine()) != "Finish") //На първия ред до получаване на командата "Finish" - име на филма – текст
            {
                movie = input;
                //studentCounter = 0;
                //standardCounter = 0;
                //kidCounter = 0;

                freeSeats = int.Parse(Console.ReadLine()); //вободните места в салона за всяка прожекция – цяло число [1 … 100]
                for (int i = 0; i < freeSeats; i++)
                {
                    input = Console.ReadLine();
                    if (input == "student")
                    {
                        studentCounter++;
                    }
                    else if (input == "standard")
                    {
                        standardCounter++;
                    }
                    else if (input == "kid")
                    {
                        kidCounter++;
                    }
                    else if (input == "End") //finishing a movie
                    {
                        break;
                    }
                    else if (input == "Finish")
                    {
                        flag = true;
                        break;
                    }
                    movieTicketsSold++;
                }
                Console.WriteLine($"{movie} - {((double)movieTicketsSold / (double)freeSeats) * 100:f2}% full."); //след всеки филм
                totalTicketsSold += movieTicketsSold;
                movieTicketsSold = 0;
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine($"Total tickets: {totalTicketsSold}");//"Total tickets: {общият брой закупени билети за всички филми}"
            Console.WriteLine($"{((double)studentCounter / totalTicketsSold) * 100:f2}% student tickets.");
            Console.WriteLine($"{((double)standardCounter / totalTicketsSold) * 100:f2}% standard tickets.");
            Console.WriteLine($"{((double)kidCounter / totalTicketsSold) * 100:f2}% kids tickets.");
            //"{процент на студентските билети}% student tickets."
            //"{процент на стандартните билети}% standard tickets."
            //"{процент на детските билети}% kids tickets."
        }
    }
}
