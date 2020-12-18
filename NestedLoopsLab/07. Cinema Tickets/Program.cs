using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalKidTickets = 0;
            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            string typeOfTicket = "";
            string filmName = Console.ReadLine();
            while (filmName != "Finish")
            {
                int kidTickets = 0;
                int studentTickets = 0;
                int standardTickets = 0;
                double freeSits = double.Parse(Console.ReadLine());
                for (int i = 0; i < freeSits; i++)
                {
                    typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "student")
                    {
                        studentTickets++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidTickets++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardTickets++;
                    }
                    else if (typeOfTicket == "End")
                    {
                        break;
                    }
                }
                totalKidTickets += kidTickets;
                totalStudentTickets += studentTickets;
                totalStandardTickets += standardTickets;
                int occupaidPlaces = kidTickets + studentTickets + standardTickets;
                Console.WriteLine($"{filmName} - {occupaidPlaces / freeSits * 100:f2}% full.");
                filmName = Console.ReadLine();
            }
            int totalTickets = totalKidTickets + totalStandardTickets + totalStudentTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudentTickets / (double)totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{totalStandardTickets / (double)totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{totalKidTickets / (double)totalTickets * 100:f2}% kids tickets.");
            
        }
    }
}
