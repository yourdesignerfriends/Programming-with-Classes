using System;
/*
This program is intended for an event planning company to track each of these events:

- Conferences: which have a speaker and have limited capacity.
- Receptions: require people to confirm their attendance or register in advance.
- Outdoor meetings: there is no limit on the number of attendees, but it is necessary that they pay attention to the weather forecast.

All events must have a title, description, date, time and address of the event.

Program Specification
- Write a program that has a base Event class along with derived classes for each type of event.
- Write a program that creates at least one event of each type and sets all of their values. 
- Call each of the methods to generate the marketing messages and output their results to the screen.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Print("\n\n\n          ######## ##     ## ######## ##    ## ######## ######## ##     ## ########  ######## ########  ########", 3);
        Print("          ##       ##     ## ##       ###   ##    ##    ##        ##   ##  ##     ## ##       ##     ##    ##", 3);    
        Print("          ##       ##     ## ##       ####  ##    ##    ##         ## ##   ##     ## ##       ##     ##    ##", 3);    
        Print("          ######   ##     ## ######   ## ## ##    ##    ######      ###    ########  ######   ########     ##", 3);    
        Print("          ##        ##   ##  ##       ##  ####    ##    ##         ## ##   ##        ##       ##   ##      ##", 3);    
        Print("          ##         ## ##   ##       ##   ###    ##    ##        ##   ##  ##        ##       ##    ##     ##", 3);    
        Print("          ########    ###    ######## ##    ##    ##    ######## ##     ## ##        ######## ##     ##    ##\n\n", 3);
        Print("           ✨ A occasion is forever And our passion is your perfect event ✨");
        Print("\n******************************************************************************************************************************** *\n", 3);

        string[] listOfEvents = {"⭐️ 1. Conferences", "⭐️ 2. Receptions", "⭐️ 3. Outdoors"};
        Console.WriteLine("");
        Console.WriteLine($"Which event would you like to plan:\n\n{listOfEvents[0]}\n{listOfEvents[1]}\n{listOfEvents[2]}\n");
        string UserChoose = Console.ReadLine();
        Console.WriteLine("\nAwesome! Let's start creating your advertising 🤠 \n\nI will need some details, please read carefully and answer the following questions:");

        void FulldMessage()
        {
            // - Full Details: Lists all of the above, plus the event type and information specific to that event type.
            Print("\n███████╗██╗   ██╗██╗     ██╗         ██████╗ ███████╗████████╗ █████╗ ██╗██╗     ███████╗", 3);
            Print("██╔════╝██║   ██║██║     ██║         ██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║██║     ██╔════╝", 3);
            Print("█████╗  ██║   ██║██║     ██║         ██║  ██║█████╗     ██║   ███████║██║██║     ███████╗", 3);
            Print("██╔══╝  ██║   ██║██║     ██║         ██║  ██║██╔══╝     ██║   ██╔══██║██║██║     ╚════██║", 3);
            Print("██║     ╚██████╔╝███████╗███████╗    ██████╔╝███████╗   ██║   ██║  ██║██║███████╗███████║", 3);
            Print("╚═╝      ╚═════╝ ╚══════╝╚══════╝    ╚═════╝ ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚══════╝╚══════╝\n\n", 3);
        }
        void StandardMessage()
        {
            //- Standard Details: Displays the title, description, date, time, and address.
            Print("\n******************************************************************************************************************************** *\n", 3);        
            Print("\n███████╗████████╗ █████╗ ███╗   ██╗██████╗  █████╗ ██████╗ ██████╗     ██████╗ ███████╗████████╗ █████╗ ██╗██╗     ███████╗", 3);
            Print("██╔════╝╚══██╔══╝██╔══██╗████╗  ██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗    ██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║██║     ██╔════╝", 3);
            Print("███████╗   ██║   ███████║██╔██╗ ██║██║  ██║███████║██████╔╝██║  ██║    ██║  ██║█████╗     ██║   ███████║██║██║     ███████╗", 3);
            Print("╚════██║   ██║   ██╔══██║██║╚██╗██║██║  ██║██╔══██║██╔══██╗██║  ██║    ██║  ██║██╔══╝     ██║   ██╔══██║██║██║     ╚════██║", 3);
            Print("███████║   ██║   ██║  ██║██║ ╚████║██████╔╝██║  ██║██║  ██║██████╔╝    ██████╔╝███████╗   ██║   ██║  ██║██║███████╗███████║", 3);
            Print("╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝     ╚═════╝ ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚══════╝╚══════╝\n\n", 3);                                                                                                                                                                             
        }
        void BriefDescription()
        {
            // Brief Description: Lists the event type, title, and date.
            Print("\n██████╗ ██████╗ ██╗███████╗███████╗    ██████╗ ███████╗███████╗ ██████╗██████╗ ██╗██████╗ ████████╗██╗ ██████╗ ███╗   ██╗", 3);
            Print("██╔══██╗██╔══██╗██║██╔════╝██╔════╝    ██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗██║██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║", 3);
            Print("██████╔╝██████╔╝██║█████╗  █████╗      ██║  ██║█████╗  ███████╗██║     ██████╔╝██║██████╔╝   ██║   ██║██║   ██║██╔██╗ ██║", 3);
            Print("██╔══██╗██╔══██╗██║██╔══╝  ██╔══╝      ██║  ██║██╔══╝  ╚════██║██║     ██╔══██╗██║██╔═══╝    ██║   ██║██║   ██║██║╚██╗██║", 3);
            Print("██████╔╝██║  ██║██║███████╗██║         ██████╔╝███████╗███████║╚██████╗██║  ██║██║██║        ██║   ██║╚██████╔╝██║ ╚████║", 3);
            Print("╚═════╝ ╚═╝  ╚═╝╚═╝╚══════╝╚═╝         ╚═════╝ ╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝        ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝\n\n", 3);                                                                                                             
        }
        switch (UserChoose)
        {
            case "1":
                Lectures lectures = new();
                lectures.BookLectureEvent();

                StandardMessage();
                lectures.StandardDetails();

                FulldMessage();
                lectures.DisplayFullDetails();

                BriefDescription();
                lectures.BriefDescription();
                break;

            case "2":
                Reception reception = new();
                reception.BookReceptionEvent();

                StandardMessage();
                reception.StandardDetails();

                FulldMessage();
                reception.DisplayFullDetails();

                BriefDescription();
                reception.BriefDescription();
                break;

            case "3":
                Outdoor outdoor = new();
                outdoor.BookOutdoorEvent();

                StandardMessage();
                outdoor.StandardDetails();

                FulldMessage();
                outdoor.DisplayFullDetails();

                BriefDescription();
                outdoor.BriefDescription();
                break;

            default:
                Console.WriteLine("You entered an invalid option, please start over");
                break;
        }
    }
    public static void Print(string text, int speed = 60)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }
}