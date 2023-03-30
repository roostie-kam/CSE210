// File: Comment //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Comment) Activity code in CS#. //
// namespace Abstraction; //
// using System; // 
// using System.Diagnostics; //

using System;
using System.Diagnostics;

// Parent Class.
// partial class Comments

class Comment
{
    public string _username;
    public string _comment;

    // Don't forget to instantiate the list (Video Comment List) to the new list before it's used.
    // public List<Comment> _comments = new List<Comment>();
    // public List<Comment> _reply = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Name: {_username}");
        Console.WriteLine("Comment:");

        // We can observe the use of the custom data type (Comment) in this loop.
        // foreach (Comment comment in _comments)
        // {
            // This calls the (comment) Display method on each job.
            // comment.Display();
        // }
    }
}