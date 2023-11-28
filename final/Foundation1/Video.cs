using System;
using System.Reflection;
using System.Collections.Generic;
using System.Transactions;

class Video
{
    //Define the Video class properties
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    //Create a list for the comments
    public List<Comment> _comments = new List<Comment>();

    //Method to return the number of comments in the comment list
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


}