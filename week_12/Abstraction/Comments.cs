// File: Comment //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Comment) Activity code in CS#. //
// namespace Program; //
// namespace Abstraction; //
// using System; // 
// using System.Diagnostics; //

namespace Program;
namespace Abstraction;
using System;
using System.Diagnostics;

// Parent Class.
// partial class Comments

class Comments
{
    public string _username;

    // Don't forget to instantiate the list (Video Comment List) to the new list before it's used.
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Name: {_username}");
        Console.WriteLine("Comment:");

        // We can observe the use of the custom data type (Comment) in this loop.
        foreach (Comment comment in _comments)
        {
            // This calls the (comment) Display method on each job.
            comments.Display();
        }
    }
}