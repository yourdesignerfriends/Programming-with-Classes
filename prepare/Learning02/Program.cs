using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1 .
        Job job1 = new Job();
        // Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        // Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
        // Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // Create a second job, set its variables, display this company on the screen as well.
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        //Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and replace them with calls to your new method. Remember that you call the method using the same dot notation such as job1.Display();
        //Return to your main function, remove any code that is displaying information, and instead, add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line. 
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}