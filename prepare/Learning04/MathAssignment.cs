using System;
// Create a new file for the MathAssignment class.
// Create this class and make sure to specify that it inherits from the base Assignment class.

public class MathAssignment : BaseAssignment 
{
    // Add the attributes as private member variables. Make sure that you 
    // do not create new member variables for the ones you inherited from the base class.
    private string _textBookSection;
    private string _problems;
    
    // Create a constructor for your class that accepts all four parameters, have it call the base 
    // class constructor to set the base class attributes that way.
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic) 
    {
        // Specific variables
        _textBookSection = section;
        _problems = problems;
    }

    // Add the GetHomeworkList() method.
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
    // Test your class by returning to the Main method and creating a new MathAssignment object and set 
    // its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
}
