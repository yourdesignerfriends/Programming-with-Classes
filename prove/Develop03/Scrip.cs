using System;
using System.Collections.Generic;
/*
The Scrip (Scripture) class hides random words, shows the text as a string. 
("Display text" refers to text with some words displayed normally 
and others replaced by underscores) 
and checks to see if the writing is completely hidden so 
you know when to end the program.
*/

public class Scrip
{
    /*
    Here the principles of encapsulation are fulfilled
    */
    private Ref _theRef;
    private Word theText;
    private List<string> _listVerse = new();

    private List<string> _hiddenWords = new();
    private string[] _text;

    public Scrip(Ref reference)
    {
        _theRef = reference;
        _text = _theRef.GetTheVerse().Split(" ");
        foreach (string word in _text)
        {
            theText = new Word(word);
            _listVerse.Add(theText.GetRenderedText());
        }
    }
    public void HideWord (int number)
    {
        Random random = new();
        
        for (int i = 0; i < number; i++)
        {
            int randNum = random.Next(_listVerse.Count());
            string removeWord = _listVerse[randNum];
            
            if (removeWord != "_______")
            {
                _hiddenWords.Add(removeWord);
            }
            if(removeWord == "_______")
            {
                randNum = random.Next(_listVerse.Count());
                
            }
            
            _listVerse.RemoveAt(randNum);
            theText.Hide();
            _listVerse.Insert(randNum, theText.GetRenderedText());
        }

    }
    public bool IsAllWordHidden()
    {
        bool IfisHidden = false;
        bool result = _listVerse.All(word => word == "_______");
        if(result)
        {
            IfisHidden = true;
        }
        return IfisHidden;
    }
    public void DisplayText()
    {
        string theRef = _theRef.GetFormattedReference();
        Console.WriteLine($"\n{theRef}\n{string.Join(" ", _listVerse)}\n");
    }
}
