using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Write a program that determines the letter grade for a course according to the following scale:
        Letter Grade / Percent
        A   100% – 93%
        A-  92% – 90%
        B+  89% – 87%
        B   86% – 83%
        B-  82% – 80%
        C+  79% – 77%
        C   76% – 73%
        C-  72% – 70%
        D+  69% – 67%
        D   66% – 63%
        D-  62% – 60%
        F   59% and lower
        */
        //Core Requirements:
        // 1. Ask the user for their grade percentage, then write a series of if-elif-else statements 
        // to print out the appropriate letter grade. (At this point, you'll have a separate print 
        // statement for each grade letter in the appropriate block.)
        Console.Write("\nWhat is your grade percentage? ");
        string user_grade = Console.ReadLine();
        int percent_number = int.Parse(user_grade);

        string grade_letter = "";
    
        if (percent_number >= 90)
        {
            grade_letter = "A";
        }
        else if (percent_number >= 80)
        {
            grade_letter = "B";
        }
        else if (percent_number >= 70)
        {
            grade_letter = "C";
        }
        else if (percent_number >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }

        // Stretch Challenge Add to your code the ability to include a "+" or "-" next to the letter grade, 
        // such as B+ or A-. For each grade. 
        string first_number = user_grade.Substring(0, 1);
        int first_digit_number = int.Parse(first_number);

        string last_number = user_grade.Substring(1, 1);
        int last_digit_number = int.Parse(last_number);
        // testing (Here I am going to do a test to check if the program separates the first and last digits of the number.)
        // Console.WriteLine($"first_number = {first_digit_number}, last_number = {last_digit_number}");
        // The test worked perfectly, yay 🤠!

        string sing = "";
        // you'll know it is a "+" if the last digit is >= 7. 
        // Recognize that there is no A+ grade, only A and A-. 
        // Add some additional logic to your program to detect this case and handle it correctly.
        if ((first_digit_number > 5 && first_digit_number < 9) && last_digit_number >= 7)
        {
            sing = "+";
        }
        // You'll know it is a minus if the last digit is < 3
        // Recognize that there is no F+ or F- grades, 
        // only F. Add additional logic to your program to detect these cases and handle them correctly.
        else if ((first_digit_number > 5 && first_digit_number <= 9) && last_digit_number < 3)
        {
            sing = "-";
        }
        // and otherwise it has no sign.
        else
        {
            sing = "";
        }

        // 3. Change your code from the first part, so that instead of printing the letter 
        // grade in the body of each if, elif, or else block, instead create a new variable 
        // called letter and then in each block, set this variable to the appropriate value. 
        // Finally, after the whole series of if-elif-else statements, have a single print 
        // statement that prints the letter grade once.
        Console.WriteLine($"You have obtained a grade of: '{grade_letter}{sing}' 🤓");

        // 2. Assume that you must have at least a 70 to pass the class. After determining 
        // the letter grade and printing it out. Add a separate if statement to determine 
        // if the user passed the course, and if so display a message to congratulate them. 
        // If not, display a different message to encourage them for next time.
        if (percent_number >= 70)
        {
            Console.WriteLine("Your hard work and perseverance have paid off. Congratulations! You passed! 🥳\n");
        }
        else
        {
            Console.WriteLine("Don't give up, next time you will do better! 💪\n");
        }

    }
}