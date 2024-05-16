using System;
/*
The Word class will need to store the text of the word itself (a string) 
and a variable to indicate whether that word is shown or hidden (a boolean).
The key behaviors for the Word class are to hide and show a word and to check 
if a word is hidden or not. In addition, a Word should have a behavior to 
get the display text of that word, which would be either the word itself 
(for example, "prayer") or, if the word were hidden, this behavior would 
return underscores (for example, "______").
*/
public class Word
{
    /*
    Here the principles of encapsulation are fulfilled
    */
    private string _theWord;
    private bool _isHidden;

    public Word(string text)
    {
        _theWord = text;
        _isHidden = false;
    }
        public string GetRenderedText()
    {
        if(_isHidden == true)
        {
            _theWord = "_______";
        }
        return _theWord;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}