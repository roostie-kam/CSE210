// File: Video //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Video) Activity code in CS#. //
// namespace Abstraction; //
// using System; // 
// using System.Diagnostics; //

using System;
using System.Diagnostics;

class Video
{
    private string _name;
    public string _author;
    public int _seconds;

    // Make sure to initialize your list to a new List before you use it.
    // public List<Video> _videos = new List<Video>();
    public List<Comment> _comments = new List<Comment>();


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Comment:");

        // Notice the use of the custom data type (Comment) in this loop.        
        foreach (Comment comment in _comments)
        {
            // This calls the Display method on each comment.
            comment.Display();
        }
    }
}