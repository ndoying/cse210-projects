using System;

public class Word
{
    public string _text;
    public bool _isHidden;

    //creates an object with the text from the Scripture class and
    // sets the hidden flat to false initially
    public Word(string text)
    {
       _text = text;
       _isHidden = false;
        
    }
}