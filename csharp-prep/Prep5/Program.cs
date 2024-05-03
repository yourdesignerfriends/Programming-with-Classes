using System;
class Program
{
    static void Main(string[] args)
    {
        // For this assignment, write a C# program that has several simple functions:
        // 6. Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
        DisplayWelcome();
        string user_name = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(user_name, numberSquared);
        
        static void DisplayWelcome()
        // 1. DisplayWelcome - Displays the message, "Welcome to the Program!"
        {
            Console.WriteLine("\n --------------- Welcome to the Program! --------------- \n");
        }
        
        static string PromptUserName()
        // 2. PromptUserName - Asks for and returns the user's name (as a string)
        {
            Console.Write("🤔 What is your name: ");
            string user_name = Console.ReadLine();
            return user_name.ToUpper();
        }
        
        static int PromptUserNumber()
        // 3. PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        {
            Console.Write("🤔 What is your favorite number?: ");
            return int.Parse(Console.ReadLine());
        }
        
        static int SquareNumber(int number)
        // 4. SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        {
            return number * number;
        }
        
        static void DisplayResult(string user_name, int squareNum)
        // 5. DisplayResult - Accepts the user's name and the squared number and displays them.
        {
            Console.WriteLine($"\n{user_name}, the square of your number is {squareNum} 🤠\n");
        }
    }
}