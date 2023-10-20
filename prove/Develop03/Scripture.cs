using System;

public class Scripture
{
    private string _text;
    private List<Word> _words;

    //receives the scripture string from main program and create a list
    public Scripture(string text)
    {
        _text = text;
        _words = new List<Word>();
    }

    //splits the scripture string into words and creates a object for each word
    // from the Word class and adds it to the list
    public void SplitPhrase()
    {
        string[] words = _text.Split(' ');

        foreach (string wordText in words)
        {
            Word word = new Word(wordText);

            _words.Add(word);
        }
    }

    //hides words randomly by setting the hidden flat to true
    public void HideWords()
    {
        Random random = new Random();
        foreach (Word word in _words)
        {
            if (word._isHidden == false)
            {
                word._isHidden = random.Next(4) == 0;
            }
            
        }
    }

    //checks to see if all the hidden flags are set to true and 
    // returning a boolean value to the main program
    public bool IsCompletelyHidden()
    {
        int _count = 0;
        int _itemCount = _words.Count;
        
        foreach (Word word in _words)
        {
            if (word._isHidden == true)
            {
                _count ++;
            }
        }

        if (_count == _itemCount)
        {
            bool _hiddenFlag = true;
            return _hiddenFlag;
        }
        else
        {
            bool _hiddenFlag = false;
            return _hiddenFlag;
        }
    }

    //displays the scripture, hiding the words with a hidden flag
    public void DisplayWords()
    {
        
        foreach (Word word in _words)
        {
            if (word._isHidden)
            {
                Console.Write($" ______");
            }
            else
            {
                Console.Write($" {word._text}");
            }
        }
    }
    
   
}

