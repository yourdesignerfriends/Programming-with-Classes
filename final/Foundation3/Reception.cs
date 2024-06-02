// Receptions, which require people to RSVP, or register, beforehand.
// For receptions, this includes an email to RSVP.
public class Reception : Event
{
    //Attributes
    private string _email;

    private void SetEmail()
    {
        Console.WriteLine("");
        Console.Write(" * Enter an email to RSVP: - ");
        _email = Console.ReadLine();
    }

    public string GetEmail()
    {
        return _email;
    }

    public void BookReceptionEvent()
    {
        SetEmail();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($" - Email to RSVP: {GetEmail()}\n");
        StandardDetails();
    }
}