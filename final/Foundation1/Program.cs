using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of videos
        List<Video> _videos = new List<Video>
        {
            new Video
            {
                //Set the video title, author and length values
                _title = "Run, Ran, Walked",
                _author = "Akira Kurosawa",
                _length = 60,
                //Create a list of comments
                _comments = new List<Comment>
                {
                    //Set the comment values
                    new Comment {_commenterName = "Joe", _text = "Excellent video, man."},
                    new Comment {_commenterName = "Jessica", _text = "Cool video."},
                    new Comment {_commenterName = "Jane", _text = "Loved the character development!"}
                },
            },
            new Video
            {
                _title = "Pyschedelically Pysched",
                _author = "Alfred Hitchcock",
                _length = 133,
                _comments = new List<Comment>
                {
                    new Comment {_commenterName = "Bill", _text = "Dude, way cool."},
                    new Comment {_commenterName = "Betty", _text = "Outstanding scenery."},
                    new Comment {_commenterName = "Barb", _text = "Totally surprised by the ending."},
                    new Comment {_commenterName = "Biff", _text = "Timeless."}
                },
            },
            new Video
            {
                _title = "The Searchers, Found",
                _author = "John Ford",
                _length = 956,
                _comments = new List<Comment>
                {
                    new Comment {_commenterName = "Zed", _text = "Blown away!"},
                    new Comment {_commenterName = "Zoe", _text = "I was a bit lost..."},
                    new Comment {_commenterName = "Zachary", _text = "Made me want to go west."},
                    new Comment {_commenterName = "Zara", _text = "Lovely dialogue"},
                    new Comment {_commenterName = "Zacchaeus", _text = "I found it a bit taxing, to be honest."}
                }
            },
        };
    
        //Display the details for each video in the list and the comments for each video
        foreach (var video in _videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine($"Comments:\n");

            foreach (var comment in video._comments)
            {
                Console.WriteLine($"\t{comment._commenterName}: {comment._text}");
            }
            
        }  
        Console.WriteLine();
    }
}