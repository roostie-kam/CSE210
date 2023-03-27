// File: Video //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Video) Activity code in CS#. //
// namespace Program; //
// namespace Abstraction; //
// using System; // 
// using System.Diagnostics; //

namespace Abstraction;
using System;
using System.Diagnostics;

public class Video
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Video> _video = new List<Video>();
    public List<Comment> _comment = new List<comment>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Comment:");

        // Notice the use of the custom data type (Comment) in this loop
        foreach (Comment comment in _comment)
        {
            // This calls the Display method on each job.
            comment.Display();
        }
    }
}