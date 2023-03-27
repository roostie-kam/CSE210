// File: Program //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Abstraction (Program) Activity code in CS#. //
// namespace Program //
// namespace Abstraction //
// using System //
// Edits? //

namespace Program;
namespace Abstraction;
using System;

// partial class Program
class Program
{
    static void Main(string[] args);
    public string _title;
    public string _username;
    public string _comment;
    public string _video;
    // public string _videolist;
    public string _seconds;

    // Don't forget to instantiate the list (Video List) to the new list before it's used.
    public List<Video> _video = new List<Video>();
   // {
       // DateTime dateojb = DateTime.Now; 
    // }
    public void Display()
    // private void Display()
    {
        // Edits?
        Console.BackgroundColor = ConsoleColor.Silver;
        Console.Clear();
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Name: {_username}");
        Console.WriteLine($"Name: {_comment}");
        Console.WriteLine($"Name: {_video}");
        Console.WriteLine($"Name: {_seconds}");
        Console.WriteLine("Video -- ");
        choice = Console.ReadLine();
        // Thread.Sleep(8000);

        // We can observe the use of the custom data type (Video) here in the loop.
        // Do I need to do more? Or any edits?
        // string in line below? //
        foreach (Video video in _video)
        foreach (Comment comment in _comment)
        foreach (Title title in _title)
        {
            // This calls the Display (Video) method in each video.
            // This calls the Display (Comment) method in each video.
            // This calls the Display (Seconds) method in each video.
            video.Display();
            video.Comment();
            video.Seconds();
        }
    }
}