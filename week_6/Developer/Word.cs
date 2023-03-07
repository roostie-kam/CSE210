// File: Word.cs //
// Date: 2/27/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-8. //

using System;

public class Word
{
    string prompt;
    string response;
    DateTime dateojb = DateTime.Now; 
    string date;

  public void Display()
{
        Console.WriteLine("book");
        Console.WriteLine("Chapter");
        Console.WriteLine("verse");
        Console.WriteLine("Enter");
        Console.WriteLine("quit");
}
    public void Write()
    {
        date = dateojb.ToShortDateString();
        // Console.WriteLine("mask")
    }
    // boolean variable (flag).
    private boolean isMasked = "false";
    public list Mask()
    {
        
    }
}