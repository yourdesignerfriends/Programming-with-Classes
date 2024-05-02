using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Overview
        In the Guess My Number game the computer picks a magic number, and then the user tries to guess it. 
        After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.
        This assignment is a little tricky, because it brings together many of the concepts you've learned in 
        this course including loops and if statements.
        */
        do
        {
            Console.Write("\nHello, I'm Analina 🙂, can you guess what number from 1 to 100 I'm thinking of 🤔... \nIf you do it you will receive a prize 🌺🌺🌺\n");

            Random magic_number_ramdom = new();
            int magic_number = magic_number_ramdom.Next(1, 101);
            int user_number = -1;
            int count = 0;

            do
            {  
                Console.Write("\nWhat is your guess? ");
                user_number = int.Parse(Console.ReadLine());

                if (magic_number > user_number)
                {
                    Console.WriteLine("\nYou're almost there, try a Higher ↑ number.");
                }
                else if (magic_number < user_number)
                {
                    Console.WriteLine("\nYou're almost there, try a Lower ↓ number.");
                }
                else
                {
                    Console.WriteLine($"\nCongratulations, you guessed it the magic number is: {magic_number}\nYou got it right in {count} attempts, here's your prize 🤗\n\n---- 🌺🌺🌺 'Learn as if you will live forever, live like you will die tomorrow' 🌺🌺🌺 —--- \nMahatma Gandhi");
                }

                count++;

            } while (user_number != magic_number);

            Console.Write("\nDo you want to play again 🤠? (type 'Yes' to continue): ");
        } while (Console.ReadLine().ToUpper() == "YES");

        Console.Write("\nThanks for playing have a great day 🙂\n\n");
    }
}