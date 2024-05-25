// 1. In a new file, create the Square class.
// 2. Make sure this class inherits from the base class.

public class Square : Shape
{
        // 4. Create the _side attribute as a private member variable.
    private double _side;

    // 3. Create a constructor that accepts the color and the side, and then call the base constructor with the color.
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // 5. Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _side * _side;
    }

}
// Return to the Main method in Program.cs to test your code.