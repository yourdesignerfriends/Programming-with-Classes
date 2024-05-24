using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
// This is the base class that contains all shared functionality
/*
Displaying the starting message
Displaying the ending message
Pausing while showing a spinner for a certain number of seconds
Pausing while showing a countdown timer for a certain number of seconds
*/

public class Activity
{
    // Private attributes 
    private string[] _spinner = {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    private string _questionsFiles = "Prompts/";
    private int _activityTime;
    
    public Activity (int time_elapsed = 0)
    {
        _activityTime = time_elapsed;
    }

    public void SetSessionTime () 
    {
        Console.Write("Write the time ⏳ in seconds of how long you want the activity to last: ");
        _activityTime = int.Parse(Console.ReadLine());
    }

    public void WelcomeMsg(string activity, string msg)
    {
        Console.WriteLine($"{activity}\n");
        Console.WriteLine($"{msg}\n");
        SetSessionTime();
        Console.Clear();
        Console.WriteLine("The activity will begin in 4 seconds");
        GetSpinner(4);
    }
    
    public void FinalMessage (int time_elapsed, string activity)
    {
        Console.WriteLine("\n🥳  ==============================================================================  🥳\n");
        Console.WriteLine($"You have successfully completed {time_elapsed} seconds of the activity:\n\n{activity}");
        Console.WriteLine("\n🥳  ==============================================================================  🥳\n\n");
        Console.WriteLine("Let's start over 🤠!");
    }

    public string GetQuestion (List<string> theList, string file)
    {
        Random random = new ();
        List<string> questions = [.. File.ReadAllLines($"{_questionsFiles}/{file}")];

        int randomIndex = random.Next(questions.Count());
        string theQuestion = questions[randomIndex];
        theList.Add(theQuestion);
        questions.RemoveAt(randomIndex);

        if (questions.Count() == 0)
        {
            questions.AddRange(theList);
        }
        return theQuestion;
    }

    public void CountDown (int num)
    {
        Timer(num, 1);
        Console.WriteLine("");
    }

    public void GetSpinner (int num) 
    {
        Timer(num);
        Console.WriteLine("");
    }
    
    public int GetActivityTime ()
    {
        return _activityTime;
    }

    public bool Timer(int num, int activity = 0) 
    {
        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(num);
        while(date < future)
        {
            if (activity == 0)
            {
                int i = 0;
                do 
                {
                    Console.Write($"{_spinner[i]}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    i++;  
                    if(i >= _spinner.Length)
                    {
                        i = 0;       
                    }
                } while (DateTime.Now < future);
            }
            
            if (activity == 1)
            {
                do 
                { 
                Console.Write(num--.ToString().PadLeft(2, '0'));
                Thread.Sleep(1000);
                Console.Write("\b \b\b \b");
                } while (DateTime.Now < future);
            }
            date = DateTime.Now;
        }
        return false;
    }

}