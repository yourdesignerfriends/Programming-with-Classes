/*
This class has the responsibility of: 
Defining a comment, tracking the name of the person who made the comment and the text of the comment.
*/
public class Comment
//Attributes
{
    private string _user;
    private string _text;

    public Comment(string name, string comment)
    {
        _user = name;
        _text = comment;
    }
    
    public string GetUser()
    {
        return _user;
    }
    public string GetText()
    {
        return _text;
    }
}