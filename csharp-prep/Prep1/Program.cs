using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Overview:
        An iconic line from the James Bond movies is that he would introduce himself as "Bond, James Bond." 
        For this assignment you will write a program that asks for your name and repeats it back in this way.
        Assignment:
        Prompt the user for their first name. Then, prompt them for their last name. Display the text 
        back all on one line saying, "Your name is last-name, first-name, last-name".
        Make sure to be precise! You should have the spacing, comma, and period appear exactly as shown in the examples.
        */
        
        Console.Write("\nWhat is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}