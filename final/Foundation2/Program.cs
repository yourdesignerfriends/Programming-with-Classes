using System;
/*
Program 2: Encapsulation with Online Ordering
Scenario
You have been hired to help a company with their product ordering system. 
They sell many products online to a variety of customers and need to produce 
packing labels, shipping labels, and compute final prices for billing.

Write a program that creates at least two orders with a 2-3 products each. 
Call the methods to get the packing label, the shipping label, 
and the total price of the order, and display the results of these methods.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("\n\n\n██    ██ ██ ██████  ████████ ██    ██  █████  ██           █████  ███████ ███████ ██ ███████ ████████  █████  ███    ██ ████████");
        Console.WriteLine("██    ██ ██ ██   ██    ██    ██    ██ ██   ██ ██          ██   ██ ██      ██      ██ ██         ██    ██   ██ ████   ██    ██");    
        Console.WriteLine("██    ██ ██ ██████     ██    ██    ██ ███████ ██          ███████ ███████ ███████ ██ ███████    ██    ███████ ██ ██  ██    ██");    
        Console.WriteLine(" ██  ██  ██ ██   ██    ██    ██    ██ ██   ██ ██          ██   ██      ██      ██ ██      ██    ██    ██   ██ ██  ██ ██    ██");   
        Console.WriteLine("  ████   ██ ██   ██    ██     ██████  ██   ██ ███████     ██   ██ ███████ ███████ ██ ███████    ██    ██   ██ ██   ████    ██\n\n");    
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Print("😎 Stay Cool, Delegate It to Us!\n"); 
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Hi, I'm Anita, your virtual assistant\nI'm here to help you create your:\n\n⏺️  Packing labels\n⏺️  Shipping labels\n⏺️  Compute final prices for billing\n\nlet's start 😁\n");
        
        // ***************************************** Firts Customer and First order ***********************************************
        Customer FirstCustomer = new();
        FirstCustomer.SetName();
        FirstCustomer.SetAddress("510 State Avenue", "Olympia", "Washington", "USA");

        Order FirstOrder = new();
        FirstOrder.AddCustomer(FirstCustomer);
        
        // First product
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("First Product");
        Console.ForegroundColor = ConsoleColor.Black;
        Product FirstCustomerP1 = new();
        // We use it in our product class
        FirstCustomerP1.SetProductName();
        FirstCustomerP1.SetPrice();
        FirstCustomerP1.SetQuantity();

        FirstOrder.AddProduct(FirstCustomerP1);
        Console.WriteLine("");
        
        // Second product
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Second Product");
        Console.ForegroundColor = ConsoleColor.Black;
        Product FirstCustomerP2 = new();

        // We use it in our product class
        FirstCustomerP2.SetProductName();
        FirstCustomerP2.SetPrice();
        FirstCustomerP2.SetQuantity();
        
        FirstOrder.AddProduct(FirstCustomerP2);
        Console.WriteLine("");

        FirstOrder.DisplayShippingInfo();

        Console.WriteLine("\n\n--------------------------------- Let's create a second order ------------------------------------\n\n\n");

        // *************************************** Second Customer and Second order **************************************************
        Customer SecondCustomer = new();
        SecondCustomer.SetName();
        SecondCustomer.SetAddress("Avenida Principal de la Urbina", "Caracas", "Distrito Capital", "Venezuela");

        Order SecondOrder = new();
        SecondOrder.AddCustomer(SecondCustomer);
        
        // First product
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("First Product");
        Console.ForegroundColor = ConsoleColor.Black;
        Product SecondCustomerP1 = new();
        // We use it in our product class
        SecondCustomerP1.SetProductName();
        SecondCustomerP1.SetPrice();
        SecondCustomerP1.SetQuantity();

        SecondOrder.AddProduct(SecondCustomerP1);
        Console.WriteLine("");
        
        // Second product
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Second Product");
        Console.ForegroundColor = ConsoleColor.Black;
        Product SecondCustomerP2 = new();

        // We use it in our product class
        SecondCustomerP2.SetProductName();
        SecondCustomerP2.SetPrice();
        SecondCustomerP2.SetQuantity();
        
        SecondOrder.AddProduct(SecondCustomerP2);
        Console.WriteLine("");

        SecondOrder.DisplayShippingInfo();

    }
    public static void Print(string text, int speed = 100)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }
}