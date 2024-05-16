using System;
/*
Keeps track of the book, chapter, and verse information.
Word: Keeps track of a single word and whether it is shown or hidden.
The Ref (Reference) class is pretty simple as far as behaviors go. It should 
have the ability to get the display text of the reference, which is just 
a string combining the book, chapter, and verse (or verses). You could 
consider having getters and setters for each of the data elements that 
this class stores, but it may be even better to use a constructor to set 
them. The constructor will be discussed in more detail below.
*/

public class Ref
{
    /*
    Here the principles of encapsulation are fulfilled
    */
    private string _book;
    private int _chapter; 
    private int _verseStart;
    private int _verseEnd;
    private string _theVerse;

    public Ref (string book, int chap, int vrs_s)
    {
        _book = book;
        _chapter = chap;
        _verseStart = vrs_s;
    }

    public Ref (string book, int chap, int vrs_s, int vrs_e)
    {
        _book = book;
        _chapter = chap;
        _verseStart = vrs_s;
        _verseEnd = vrs_e;
    }
        public string GetFormattedReference()
    {
        if (_verseEnd == 0)
        {
            return $"Book 📕: {_book}\nChapter: {_chapter}/nVerse: {_verseStart}\n";
        }
        else
        {
            return $"Book 📕: {_book}\nChapter: {_chapter}\nVerse: {_verseStart}-{_verseEnd}\n";
        }
        
    }
        public void SetVerse()
    {
        _theVerse  = Console.ReadLine();
    }

    public string GetTheVerse()
    {
        return _theVerse;
    }
    public string GetBook()
    {
        return _book;
    }
        public int GetChap() {
        return _chapter;
    }
    public int GetVrs_S()
    {
        return _verseStart;
    }
    public int GetVrs_E()
    {
        return _verseEnd;
    }
}