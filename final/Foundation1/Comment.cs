/*
This class has the responsibility of: 
Defining a comment, tracking the name of the person who made the comment and the text of the comment.
*/
public class Comment
{
    // Attributes
    private string _user;
    private string _text;

    public Comment(string name, string comment)
    {
        _user = name;
        _text = comment;
    }

    // A getter (get) fetches the value of a variable, while a setter (set) assigns a value to it 🤓
    // I know it's not necessary but I like to explain my code so I can use it as a kind of manual for the future
    public string GetUser()
    {
        return _user;
    }
    public string GetText()
    {
        return _text;
    }
}