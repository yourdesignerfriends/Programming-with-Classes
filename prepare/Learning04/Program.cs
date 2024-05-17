using System;

class Program
{
    static void Main(string[] args)
    {
        // Test your class by returning to the Main method in the Program.cs file. 
        // Create a simple assignment, call the method to get the summary, and then display it to the screen.
        Console.WriteLine("-----------------------------------------------------------------");
        BaseAssignment Assignment = new BaseAssignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(Assignment.GetSummary());
        Console.WriteLine("");

        MathAssignment mathAssignment = new ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList() + "\n");

        WritingAssignment writingAssignment = new ("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine("-----------------------------------------------------------------");
    }
}