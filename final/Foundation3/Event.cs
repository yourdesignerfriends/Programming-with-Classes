using System.Globalization;
/*
(Any data or methods that are common among all types of events should be in the base class)
- Standard Details: Displays the title, description, date, time, and address.
- Full Details: Lists all of the above, plus the event type and information specific to that event type. 
For conferences, this includes the name and capacity of the speaker. 
For receptions, this includes an email to RSVP. For outdoor gatherings, this includes a weather statement.
- Brief Description: Lists the event type, title, and date.
*/
public class Event
{
    //Attributes
    private string _tiltle;
    private string _description;
    private DateTime _date;
    private string _time;
    private string _type;
    private Address _address = new();

    // Get Type
    private string GetEventType()
    {
        return _type;
    }
    // Set Type
    public void SetEventType(string theEvent)
    {
        _type = theEvent;
    }

    // Get Title
    public string GetTitle()
    {
        return _tiltle;
    }
    // Set Title
    private void SetTitle()
    {
        Console.WriteLine("");
        Console.Write(" * Enter the name of the event\n - ");
        _tiltle = Console.ReadLine();
    }

    // Get Description
    public string GetDescription()
    {
        return _description;
    }
    // Set Description
    private void SetDescription()
    {
        Console.WriteLine("");
        Console.Write(" * Enter the description of the event\n - ");
        _description = Console.ReadLine();
    }

    // Get Date
    public string GetDate()
    {
        return _date.ToString("MMMM, dd yyyy", CultureInfo.InvariantCulture);
    }
    // Set Date
    private void SetDate()
    {
        Console.WriteLine("");
        Console.Write(" * Enter a date in MM/dd/yyyy format (example 01/22/2024):\n  - ");
        _date = DateTime.Parse(Console.ReadLine());
    }

    // Get Time
    public string GetTime()
    {
        return _time;
    }
    // Set Time
    private void SetTime()
    {
        Console.WriteLine("");
        Console.Write(" * What will be the time of the event?\n  - ");
        _time = Console.ReadLine();
    }

    // Standard Details: Displays the title, description, date, time, and address.
    public void BookEvent()
    {
        SetTitle();
        SetDescription();
        SetDate();
        SetTime();
        _address.SetAddress();
    }
    public void StandardDetails()
    {
        Console.WriteLine($" - Event title: {GetTitle().ToUpper()}\n\n - Event Description: {GetDescription()}\n - Event Date: {GetDate()}\n - Time: {GetTime()}\n{_address.DisplayfullAddress()}");
        Console.WriteLine("\n******************************************************************************************************************************** *\n");
    }
    // Brief Description: Lists the event type, title, and date.
    public void BriefDescription()
    {
        Console.WriteLine($" - Event title: {GetTitle().ToUpper()}\n\n - Event type: {GetEventType()}\n - Event date: {GetDate()}");
        Console.WriteLine("\n******************************************************************************************************************************** *\n\n\n");
    }
}