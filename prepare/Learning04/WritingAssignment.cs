using System;
// Follow the same pattern as before by creating a new file for the WritingAssignment class.
// Create the class and set up the inheritance relationship.

public class WritingAssignment : BaseAssignment
{
    /*
    Add the member variables and set up the constructor as you did for the MathAssignment class.
    Add the GetWritingInformation() method.
    Notice that this method needs to access the _studentName variable defined in the base class. 
    Even though WritingAssignment class inherited this attribute, it is private, so you cannot 
    access it directly in the derived class.
    To get the data you need for the method you can either make the variable 
    protected in the base class, or you can create a public GetStudentName method to return it.
    Return to Main and test your new class.
    */
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";
    }
}