//1. Create a class to hold fraction.
//2. The class should be in its own file.

public class FractionHold
{
    //3. The class should have two attributes for the top and bottom numbers.
    //4. Make sure the attributes are private.
    //In this part I am creating two private attributes of type int
    private int _top;
    private int _bottom;
    
    //1. Now I'm going to create the constructors 🙂
    //a. Constructor that has no parameters that initializes the number to 1/1.
    public FractionHold() 
    {
        _top = 1;
        _bottom = 1;
        
    }
    //b. Constructor that has one parameter for the top and that initializes the 
    //denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public FractionHold(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //c. Constructor that has two parameters, one for the top and one for the bottom.
    public FractionHold(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    //At this point I'm ready to go back to my Program.cs file, and verify that I can create fractions using these three constructors.

    //Create the Getters and Setters
    //Create getters and setters for both the top and the bottom values.
    public int GetterTop()
    {
        return _top;
    }
    public void SetterTop(int top)
    {
        _top = top;
    }
    public int GetterBottom()
    {
        return _bottom;
    }
    public void SetterBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Create methods to return the representations
    //Create a method called GetFractionString that returns the fraction in the form 3/4.
    //Create a method called GetDecimalValue that returns a double that is the result 
    //of dividing the top number by the bottom number, such as 0.75. 

    public string GetFractionString()
    {
        string TextFormat = $"{_top}/{_bottom}";
        return TextFormat;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    //Now we need to go back to our Program.cs to verify that we can call these methods

}
