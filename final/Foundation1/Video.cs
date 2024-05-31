/*
This class has the responsibility to:
Track the title, author, and length (in seconds) of the video. 
Each video also has responsibility to store a list of comments, 
and should have a method to return the number of comments.
*/
public class Video
{
    //Attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new();

    public void SetVideo(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }
    public void DisplayInfo()
    {
        string meta = $"Author of Video: {_author}\nTitle: {_title}\nVideo length: {_length} minutes";
        Console.WriteLine(meta);
    }
    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void AddComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"User: {comment.GetUser()}\nComment: {comment.GetText()}\n");
        }
    }
}

