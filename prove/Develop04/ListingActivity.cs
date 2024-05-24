using System;
// Get a random prompt
// Get a list of responses from the user
// Contain a run function (inherited)

public class ListingActivity : Activity

{
    // Attributes
    private string _activityTitle = " ___      ___   _______  _______  ___   __    _  _______\n|   |    |   | |       ||       ||   | |  |  | ||       |\n|   |    |   | |  _____||_     _||   | |   |_| ||    ___|\n|   |    |   | | |_____   |   |  |   | |       ||   | __\n|   |___ |   | |_____  |  |   |  |   | |  _    ||   ||  |\n|       ||   |  _____| |  |   |  |   | | | |   ||   |_| |\n|_______||___| |_______|  |___|  |___| |_|  |__||_______|";
    private string _activity_Description = "Guide you to think broadly, helping you list as many things as you can in a given area of strength or positivity.\n🙂 You may discover more breadth than you previously thought.";
    private string _listingFile = "listOfTenderMercies.txt";
    private List<string> _ListingQuestion = new ();
    private List<string> _userInputs;

    // Constructors
    public ListingActivity()
    {
    }

    private void DisplayListItem()
    {
        DateTime date = DateTime.Now;
        WelcomeMsg(_activityTitle, _activity_Description);
        DateTime future = date.AddSeconds(GetActivityTime());

        // After displaying the prompt, the program should give them a countdown of several seconds 
        // to begin thinking about the prompt. Then, it should prompt them to keep listing items.
        Console.WriteLine($"Write as many responses as you can to the following message:\n");
        Console.WriteLine($"👉 {GetQuestion(_ListingQuestion, _listingFile)}\n");
        Console.Write("You can start in  \n");
        CountDown(7);

        _userInputs = new ();

        do
        {
          Console.Write("⏺️  ");
          string listResponse = Console.ReadLine();
          _userInputs.Add(listResponse);
        } while (DateTime.Now < future);
    }

    private void TenderMerciesAmount()
    {
        Console.WriteLine($"\nYou wrote {_userInputs.Count} Tender Mercies 🥰 🤗");
        FinalMessage(GetActivityTime(), _activityTitle);
    }

    public void StartActivity()
    {
        DisplayListItem();
        TenderMerciesAmount();
    }

}
