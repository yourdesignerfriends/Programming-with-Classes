using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        
        Console.WriteLine("\n🌺 'Those who keep a personal journal 📗 are more likely to keep the Lord in remembrance in their daily lives' 🌺 -- Spencer Woolley Kimball --\n");
        Console.WriteLine("👋 Hello, I'm your friend Analina 😊, I would love to know what was the most interesting thing you did today.");
        Console.WriteLine("");
        
        Journal journal = new();
        
        DisplayJournal display = new();

        int UserResponse;

        do
        {
            display.ShowMenu();
            UserResponse = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (UserResponse == 1)
            {
                Console.Write("Fantabulous! We start writing something new 🤠 What name do you want this Journal to have? ");
                string entryName = Console.ReadLine();
                Console.WriteLine("");
                
                journal._fileName = entryName;
                journal._date = currentDateTime.ToLongDateString();
                journal.Entry(NewFile: journal.fileAccessName(journal._fileName), Question: display.GetQuestion());
            }
        
            else if (UserResponse == 2)
            {
                journal.Continue(Question: display.GetQuestion());
            }

            else if (UserResponse == 3)
            {
                display.SaveJournal();
            }

            else if (UserResponse == 4)
            {
                display.FileDelete();
            }
        } while (UserResponse != 5);
        
        Console.WriteLine("Good bye take care 🤗\n");
    }
}