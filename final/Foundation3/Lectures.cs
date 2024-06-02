// Lectures, which have a speaker and have a limited capacity.
// Conferences: which have a speaker and have limited capacity.
public class Lectures : Event
{
    //Attributes
    private string _speaker;
    private int _limitedCapacity;

    private void SetSpeakerName()
    {
        Console.WriteLine("");
        Console.Write(" *   What is the name of the speaker?\n  -  ");
        _speaker = Console.ReadLine();
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    private void SetLimitedCapacity()
    {
        Console.WriteLine("");
        Console.Write(" *   Enter the capacity limit of the event (Please enter in numbers, do not use letters)\n -  ");
        _limitedCapacity = int.Parse(Console.ReadLine());
    }

    public int GetLimitedCapacity()
    {
        return _limitedCapacity;
    }

    public void BookLectureEvent()
    {
        SetSpeakerName();
        SetLimitedCapacity();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"\n - Speaker: {GetSpeaker()}\n - Limited capacity: {GetLimitedCapacity()}\n");
        StandardDetails();
    }
}