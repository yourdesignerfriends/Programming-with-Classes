using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello my friends, my name is Analina 🤠 and with this program we are going to learn the principles of encapsulation 💊\n");
        //In your Program.cs file, verify that you can create fractions using all three of these constructors. 
        //For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).
        FractionHold f1 = new ();
        FractionHold f2 = new (5);
        FractionHold f3 = new (3, 4);
        FractionHold f4 = new (1, 3);

        //Now we have to create the Getters and Setters At this point we must return to the FraccionHold class
        //In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change 
        //the values and then getters to retrieve these new values and then display them to the console.
        Console.WriteLine("----------------------------");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine("----------------------------");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine("----------------------------");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine("----------------------------");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine("----------------------------\n");
    }
}