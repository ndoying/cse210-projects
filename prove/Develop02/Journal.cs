using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{

    //Declare a List<string>
    private List<string> _entryList = new List<string>();
    
    //Method to add items to _entryList
    public void AddItemToList(string item)
    {
        _entryList.Add(item); 
    }

    //Method to diplay the items in _entryList
    public void DisplayJournal()
    {
        foreach (string entry in _entryList)
        {
            //string EntryToDisplay = _entryList[entry];
            Console.WriteLine("\n" + entry);
        }
    }

    //Method to load a file into _entryList
    public void LoadJournal(string loadfilename)
    {
        string _loadFileName = loadfilename;
        string[] _lines = System.IO.File.ReadAllLines(_loadFileName);

        int _insertNumber = 0;

        foreach (string line in _lines)
        {
            _entryList.Insert(_insertNumber, line);
            _insertNumber = _insertNumber + 1;
        }
    }
    // Method to create a file from _entryList
    public void SaveJournal(string filename)
    {
        string _fileName = filename;

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (string entry in _entryList)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}
    