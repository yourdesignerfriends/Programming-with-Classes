using System;
// Exceeding Requirements:
// I'm studying how to use ASCII in C# and I use a generator to make these letters, I think looks great 🤠.
// At the end of the program I gave the user the option if they wanted to continue learning another Scripture.
// I think it's a problem that the system only has a default list of scriptures, so the program works with user-supplied scriptures.
// 
class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("███████╗ ██████╗██████╗ ██╗██████╗ ████████╗██╗   ██╗██████╗ ███████╗    ███╗   ███╗ █████╗ ███████╗████████╗███████╗██████╗ ██╗   ██╗");
            Console.WriteLine("██╔════╝██╔════╝██╔══██╗██║██╔══██╗╚══██╔══╝██║   ██║██╔══██╗██╔════╝    ████╗ ████║██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗╚██╗ ██╔╝");
            Console.WriteLine("███████╗██║     ██████╔╝██║██████╔╝   ██║   ██║   ██║██████╔╝█████╗      ██╔████╔██║███████║███████╗   ██║   █████╗  ██████╔╝ ╚████╔╝ ");
            Console.WriteLine("╚════██║██║     ██╔══██╗██║██╔═══╝    ██║   ██║   ██║██╔══██╗██╔══╝      ██║╚██╔╝██║██╔══██║╚════██║   ██║   ██╔══╝  ██╔══██╗  ╚██╔╝  ");
            Console.WriteLine("███████║╚██████╗██║  ██║██║██║        ██║   ╚██████╔╝██║  ██║███████╗    ██║ ╚═╝ ██║██║  ██║███████║   ██║   ███████╗██║  ██║   ██║   ");
            Console.WriteLine("╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝        ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝   \n\n");
                                                                                                                                       
            Console.WriteLine("RULES:\n");
            Console.WriteLine("⏺️  This program displays the full scripture and then hides a few words at a time until the complete scripture is hidden.\n⏺️  If you type quit, the program should end.\n⏺️  If you press the enter key (without typing quit), the program should hide a few random words in the scripture.\n⏺️  The program should continue prompting the user and hiding more words until all words in the scripture are hidden.\n⏺️  When all words in the scripture are hidden, the program should end.\n");
            Console.WriteLine("LET US BEGIN:\n"); 
            
            Console.Write("⏺️  Enter the name of the book and end with a period (.)\n⏺️  Enter the chapter of the book in numbers followed by a period (.)\n⏺️  Enter the opening verse followed by a period (.)\n⏺️  Enter the ending verse followed by a period (.)\n\nExample: Isaiah.53.3.5\n\nWrite your scripture reference here (💡 remember to follow the format explained above): ");
            string[] listRef = Console.ReadLine().Split(".");

            Ref theReference = new(book:"", chap:0, vrs_s:0, vrs_e:0);
            
            if (listRef.Count() == 4)
            {
                theReference = new Ref(book:listRef[0], chap:int.Parse(listRef[1]), vrs_s:int.Parse(listRef[2]), vrs_e:int.Parse(listRef[3]));
            }
            if (listRef.Count() == 3)
            {
                theReference = new Ref(book:listRef[0], chap:int.Parse(listRef[1]), vrs_s:int.Parse(listRef[2]));
            }
            Console.WriteLine("\nNow write the verses here (when you finish typing press enter):\n ");
            theReference.SetVerse();
            Scrip scrip = new(theReference);
            
            string Quit = "";
            while (Quit != "quit")
            {
                if(scrip.IsAllWordHidden())
                {
                    Console.WriteLine("\nCongratulations 🥳 you have now learned a new Scripture Mastery 🤓\n");
                    break;
                }

                scrip.HideWord(5);
                Console.Clear();
                Console.WriteLine("Can you remember the missing words? 🤓");
                scrip.DisplayText();

                Console.Write("⏺️  Press the Enter key (without typing exit) if you want the program to hide some random words in the Scriptures.\n⏺️  Please type the word 'quit' if you want the program to end.\n\n");
                Quit = Console.ReadLine().ToLower();
            }
            Console.Clear();
            Console.Write("\nWould you like to learn another writing 🤠? (type 'Y' to continue or 'N' to finish): ");
        } while (Console.ReadLine().ToUpper() == "Y");

        Console.Write("\nThank you for using the 📕 SCRIPTURE MASTERY 📕 program. have a great day 🙂\n\n");
    }
}