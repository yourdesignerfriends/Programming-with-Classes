using System;
using System.Threading;
/*
Specification:
Write an Eternal Quest program to track various kinds of goals.
- Use inheritance 
- Use polymorphism
- Follow the principles of encapsulation and abstraction

Exceeding requirements:
Add color to my code
Add keyboard animation
add ascii text
*/
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("\n\n███████ ████████ ███████ ██████  ███    ██  █████  ██           ██████  ██    ██ ███████ ███████ ████████");
        Console.WriteLine("██         ██    ██      ██   ██ ████   ██ ██   ██ ██          ██    ██ ██    ██ ██      ██         ██   "); 
        Console.WriteLine("█████      ██    █████   ██████  ██ ██  ██ ███████ ██          ██    ██ ██    ██ █████   ███████    ██   "); 
        Console.WriteLine("██         ██    ██      ██   ██ ██  ██ ██ ██   ██ ██          ██ ▄▄ ██ ██    ██ ██           ██    ██   "); 
        Console.WriteLine("███████    ██    ███████ ██   ██ ██   ████ ██   ██ ███████      ██████   ██████  ███████ ███████    ██   "); 
        Console.WriteLine("                                                                   ▀▀                                    "); 
        Console.ForegroundColor = ConsoleColor.White;
        Print("The only thing that stands between you and your dream is the will to try and the belief that it is actually possible. - Joel Brown.\n\n"); 
        Console.WriteLine("Welcome to 'Eternal Quest', this is a program that tracks various types of goals you may have,\nsuch as studying the scriptures every day, finishing a project, or even breaking a bad habit.\nIt's set up to track your progress on these goals and offer points to encourage you to keep working.\n\nThis program could help each of us in our 'Eternal Quest' to return to be with our Heavenly Father 😇 ˚₊‧꒰ა ♡ ໒꒱ ‧₊˚");
        Console.WriteLine("\nPress enter to start 🤠\n");
        Console.ReadKey();
        
        Console.Clear();
        GoalManager goalManager = new();
        goalManager.Start();
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