using System;
class Program
{
    static void Main(string[] args)
    {
        // In your Main method, create a list to hold shapes (Hint: The data type should be List<Shape>).
        List<Shape> shapes = new List<Shape>();

        // Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
        Square s1 = new Square("Red 🔴", 3);
        shapes.Add(s1);

        // Create a Rectangle instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
        Rectangle s2 = new Rectangle("Blue 🔵", 4, 5);
        shapes.Add(s2);

        // Create a Circle instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
        Circle s3 = new Circle("Green 🟢", 6);
        shapes.Add(s3);

        // Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"\n🔘  The {color} shape has an area of {area}.\n");
        }
    }
}
