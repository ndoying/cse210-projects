using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public string GetWord()
    {
        return _text;
    }

    public bool GetBool()
    {
        return _isHidden;
    }

    public void SetBool(bool flag)
    {
        _isHidden = flag;
    }

    //creates an object with the text from the Scripture class and
    // sets the hidden flat to false initially
    public Word(string text)
    {
       _text = text;
       _isHidden = false;
        
    }
}