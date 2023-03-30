// File: Program //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Program) Activity code in CS#. //
// namespace Abstraction //
// using System //

using System;
// using Abstraction;

// partial class Program
class Program
{
    static void Main(string[] args)
    {
    // Don't forget to instantiate the list (Video List) to the new list before it's used.
    List<Video> _videos = new List<Video>();
    // string choice;

    // {
    // DateTime dateojb = DateTime.Now; 
    // }

        // We can observe the use of the custom data type (Video) here in the loop.
        // Do I need to do more? Or any edits?
        // string in line below? //
        foreach (Video video in _videos)
        // foreach (Comment comment in _comment)
        // foreach (Title title in _title)
        {
            // This calls the Display (Video) method in each video.
            // This calls the Display (Comment) method in each video.
            // This calls the Display (Seconds) method in each video.
            video.Display();
        }
    }
}        