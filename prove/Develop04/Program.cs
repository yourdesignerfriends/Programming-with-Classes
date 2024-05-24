using System;
using System.Threading;
// This class handles the menu and interaction
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("🌺 --------------------------------------------------------------------------------------------- 🌺\n");
        Print("                                         Welcome to                                           \n");
        Console.WriteLine(" __   __  ___   __    _  ______   _______  __   __  ___      __    _  _______  _______  _______ ");
        Console.WriteLine("|  |_|  ||   | |  |  | ||      | |       ||  | |  ||   |    |  |  | ||       ||       ||       |");
        Console.WriteLine("|       ||   | |   |_| ||  _    ||    ___||  | |  ||   |    |   |_| ||    ___||  _____||  _____|");
        Console.WriteLine("|       ||   | |       || | |   ||   |___ |  |_|  ||   |    |       ||   |___ | |_____ | |_____ ");
        Console.WriteLine("|       ||   | |  _    || |_|   ||    ___||       ||   |___ |  _    ||    ___||_____  ||_____  |");
        Console.WriteLine("| ||_|| ||   | | | |   ||       ||   |    |       ||       || | |   ||   |___  _____| | _____| |");
        Console.WriteLine("|_|   |_||___| |_|  |__||______| |___|    |_______||_______||_|  |__||_______||_______||_______|\n\n");
        Print("'Training your mind to be in the present moment is the number one key to making healthier choices'\n",100);
        Console.WriteLine("🌺 --------------------------------------------------------------------------------------------- 🌺");
        Console.WriteLine("\nDue to stress and the frenetic pace of life we forget to do things that are important for our mental health.\nIn this program we present three simple activities that will help you\nbe where you are and not lose your life\n");
        
        // Attribute
        string userChoice;
 
        Breathing breathing = new Breathing();
        ReflectingActivity reflection = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        
        do
        {
            Print("\nPlease select one of the following options:\n");
            Console.WriteLine("⏺️  A. Listing Activity\n⏺️  B. Refelecting Activity\n⏺️  C. Breathing Activity\n⏺️  D. End the program\n");
            
            userChoice = Console.ReadLine().ToUpper(); 

            if (userChoice == "A")
            {
                Console.Clear();
                listing.StartActivity();
            }
            else if(userChoice == "B")
            {
                Console.Clear();
                reflection.StartActivity();
            }
            else if (userChoice == "C")
            {
                Console.Clear();
                breathing.StartActivity();
            }

        } while (userChoice != "D");

        Print("\nThank you for using the 🌺 MINDFULNESS 🌺 program. have a great day 🙂\n\n");
        
    }
    public static void Print(string text, int speed = 40)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }
}