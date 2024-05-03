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
        // 1. DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("\n --------------- Welcome to the Program! --------------- \n");
        }
        // 2. PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("🤔 What is your name: ");
            string user_name = Console.ReadLine();
            return user_name.ToUpper();
        }
        // 3. PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("🤔 What is your favorite number?: ");
            return int.Parse(Console.ReadLine());
        }
        // 4. SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            return number * number;
        }
        // 5. DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string user_name, int squareNum)
        {
            Console.WriteLine($"\n{user_name}, the square of your number is {squareNum} 🤠\n");
        }
    }
}