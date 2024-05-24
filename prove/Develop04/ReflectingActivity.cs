using System;
// Get a random prompt to show
// Get a random question about the prompt
// Display the prompt
// Display questions about the prompt and get answers
// Contain a run function (inherited)

public class ReflectingActivity : Activity
{
    // Attributes
    private string _activityTitle = " ______    _______  _______  ___      _______  _______  _______  ___   __    _  _______\n|    _ |  |       ||       ||   |    |       ||       ||       ||   | |  |  | ||       |\n|   | ||  |    ___||    ___||   |    |    ___||       ||_     _||   | |   |_| ||    ___|\n|   |_||_ |   |___ |   |___ |   |    |   |___ |       |  |   |  |   | |       ||   | __\n|    __  ||    ___||    ___||   |___ |    ___||      _|  |   |  |   | |  _    ||   ||  |\n|   |  | ||   |___ |   |    |       ||   |___ |     |_   |   |  |   | | | |   ||   |_| |\n|___|  |_||_______||___|    |_______||_______||_______|  |___|  |___| |_|  |__||_______|\n";
    private string _activity_Description = "Think deeply, consider a certain experience in which you were successful or demonstrated strength.\nThen, with the next question, reflect more deeply on details of this experience.\n🙂 You may discover more depth than you previously thought.";
    private List<string> _questionsUsed  = new ();
    private List<string> _reflectionQuestionUsed = new ();
    private string _questionFile = "Questions.txt";
    private string _reflectionQuestionFile = "reflectionQuestion.txt";

    // Constructors
    public ReflectingActivity () : base()
    {
    }
    private void reflectionQuestion()
    {   
        WelcomeMsg(_activityTitle, _activity_Description);
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("Consider the following Question:\n");
        Console.WriteLine($"👉 {GetQuestion(_questionsUsed, _questionFile)}");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.ReadLine();
        Console.Clear();
    }

    private void PonderQuestion()
    {
        Console.WriteLine("");
        Console.Write($"⏺️  {GetQuestion(_reflectionQuestionUsed, _reflectionQuestionFile)} ");
        GetSpinner(10);
        Console.WriteLine("");
        Console.Write($"⏺️  {GetQuestion(_reflectionQuestionUsed, _reflectionQuestionFile)} ");
        GetSpinner(10);
        FinalMessage(GetActivityTime(), _activityTitle);
    }

    public void StartActivity()
    {
        reflectionQuestion();
        PonderQuestion();
    }
}
