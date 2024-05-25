using System;
// In a new file, create the Circle class.
// Make sure this class inherits from the base class.
public class Circle : Shape
{
     // Create the _radius attribute as a private member variable.
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Override the GetArea() method from the base class and fill in the body of this function to return the area.    
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
// Return to the Main method in Program.cs to test your code.