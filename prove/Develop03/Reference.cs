using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;
    private string _myRef;
    
    //constructor for single verse references
    public Reference(string book, string chapter, string firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = "";
        PickReferenceType();
        
    }

    //constructor for multiple verse references
    public Reference(string book, string chapter, string firstVerse, string lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        PickReferenceType();
    }

    //selects the type of reference that has been received from main program
    private void PickReferenceType()
    {
        if (!string.IsNullOrEmpty(_lastVerse))
        {
            _myRef = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }

        else 
        {
            _myRef = $"{_book} {_chapter}:{_firstVerse}";
            
        }
        
        
    }

    //displays the reference
    public void DisplayRef()
    {
        Console.Write(_myRef);
    }

}