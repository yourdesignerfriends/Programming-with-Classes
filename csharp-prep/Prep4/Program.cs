using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // I like to start by giving instructions to the user first.
        Console.WriteLine("\nHello, my name is Analina 🙂, this program is designed to store a list of personalized numbers just for you.\n\nThe rules are very easy, you just have to enter a list of numbers and write 0 when you are done.\nLet us begin 🤠\n");
        // Then we declare a variable to hold the list. I can write it on the same line List<int> numbers = new List<int>(); but I like to do it separately.
        List<int> list_of_numbers;
        list_of_numbers = new List<int>();
        // variables
        int user_number;
        do
        { 
            Console.Write("Please enter a number: ");
            user_number = int.Parse(Console.ReadLine());
            // The program will only add the numbers to the list if the number is different than zero.
            if (user_number != 0) list_of_numbers.Add(user_number);
        // The loop will only repeat if the number entered by the user is different from zero.
        } while (user_number != 0);

        // variables
        int sum = 0;
        int highest_number = list_of_numbers[0];
        int lower_number = list_of_numbers[0];
        // The foreach statement enumerates the elements of a collection and executes its body for each element of the collection.
        foreach (int number in list_of_numbers)
        {
            // Compute the sum, or total, of the numbers in the list
            sum += number;
            // Find the highest number in the list.
            if (number > highest_number)
                {
                highest_number = number;
                }
            // Find the lower number in the list.
            if (number < lower_number)
                {
                lower_number = number;
                }
        }
        // Calculate the average of the numbers in the list
        float average = ((float)sum) / list_of_numbers.Count;

        // Prints all messages for the user.
        Console.WriteLine($"\n⏺️ The sum of all the numbers in the list is: {sum}");
        Console.WriteLine($"⏺️ The average of the numbers on the list is: {average}");
        Console.WriteLine($"⏺️ The highest number on the list is: {highest_number}");
        Console.WriteLine($"⏺️ The lower number on the list is: {lower_number}\n");
        Console.WriteLine($"Below you can see the ordered list of all the numbers you entered:");

        // Finally, the program will display the entire ordered list of numbers entered by the user.
        list_of_numbers.Sort();
        foreach (var number in list_of_numbers)
        {
        Console.WriteLine($"➡️ {number}");
        }
    }
}