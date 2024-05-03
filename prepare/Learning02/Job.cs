using System;
// Design the Classes "Job"
// Create a new file for your job class. By convention this should be named Job.cs.
public class Job
// Create the class (Hint this is the public class Job syntax). 
{
    // Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    // Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    // Return to your Job.cs file and add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. By convention, this method should begin with a capital letter, such as Display, and if you have multiple words each word should be capitalized, such as DisplayJobDetails .
    public void DisplayJobDetails()
    {
        string description = $"{_jobTitle} ({_company}) {_startYear} {_endYear}";
        Console.WriteLine(description);
    }
}