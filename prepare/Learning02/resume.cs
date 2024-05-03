using System;
//Design the Classes "Resume"
// Create a new file for your Resume class. Each class should be in its own file and the file name should match the name of the class.
public class Resume
{
    // Create the member variable for the person's name.
    // Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize this to a new list right when you declare it..)
    public string _name;
    public List<Job> _jobs = new();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}