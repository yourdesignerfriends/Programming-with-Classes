using System;
// Contain a run function (inherited)
/*
Breathing Activity
1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
2. The description of this activity should be something like: "This activity will help you relax by walking your through 
   breathing in and out slowly. Clear your mind and focus on your breathing."
3. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
4. After each message, the program should pause for several seconds and show a countdown.
5. It should continue until it has reached the number of seconds the user specified for the duration.
6. The activity should conclude with the standard finishing message for all activities.
*/

public class Breathing : Activity
{
    // Attributes
    private string _activityTitle = " _______  ______    _______  _______  _______  __   __  ___   __    _  _______\n|  _    ||    _ |  |       ||   _   ||       ||  | |  ||   | |  |  | ||       |\n| |_|   ||   | ||  |    ___||  |_|  ||_     _||  |_|  ||   | |   |_| ||    ___|\n|       ||   |_||_ |   |___ |       |  |   |  |       ||   | |       ||   | __ \n|  _   | |    __  ||    ___||       |  |   |  |       ||   | |  _    ||   ||  |\n| |_|   ||   |  | ||   |___ |   _   |  |   |  |   _   ||   | | | |   ||   |_| |\n|_______||___|  |_||_______||__| |__|  |___|  |__| |__||___| |_|  |__||_______|\n";                                    
    private string _activity_Description = "Help you control your breathing to have a deep breathing session for a certain time.\n🙂 You may find more peace and less stress through exercise.\n\nTo do it: \n1. Relax your neck and shoulders.\n2. Keeping your mouth closed, inhale slowly through your nose for 2 counts.\n3. Pucker or purse your lips as though you were going to whistle.\n4. Exhale slowly by blowing air through your pursed lips for a count of 4.";
    public Breathing ()
    {
    }

    private void Breath ()
    {
        WelcomeMsg(_activityTitle, _activity_Description);

        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(GetActivityTime());

        int breathingDuration = 4;
        
        do
        {
            Console.Write("Inhale slowly ");
            CountDown(breathingDuration);
            Console.Write("Exhale slowly ");
            CountDown(breathingDuration);
            Console.WriteLine("------------");

        } while (DateTime.Now < future);
        FinalMessage(GetActivityTime(), _activityTitle);
        Console.WriteLine("");
    }

    public void StartActivity()
    {
        Breath();
    }
}