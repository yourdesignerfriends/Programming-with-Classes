// 1. In a new file, create the Shape class (This will be the parent class)
// public abstract class Shape

public abstract class Shape
{
    // 2. Add the color member variable (Attributes) and... 
    private string _color;

    // 3. Create a constructor that accepts the color and set its.
    public Shape(string color)
    {
        _color = color;
    }

    // a getter and setter for it.
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    // 4. Create a virtual method for GetArea().
    // (must also be declared to be abstract.)
    public abstract double GetArea();
}