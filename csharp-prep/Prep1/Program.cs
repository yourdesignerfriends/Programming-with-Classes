using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;

        Console.Write("\nYour name is {1},", last_name, myTI.ToTitleCase( last_name ));
        Console.Write(" {1}", name, myTI.ToTitleCase( name ));
        Console.WriteLine(" {1}.\n", last_name, myTI.ToTitleCase( last_name ));
    }
}