using System;
// In a new file, create the Rectangle class.
// Make sure this class inherits from the base class.
public class Rectangle : Shape
{
    // Create the _length and _width attributes as a privates members variables.
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _length * _width;
    }
}
// Test these classes back in Main and make sure they work as expected.