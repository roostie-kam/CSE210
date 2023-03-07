// File: Scripture.cs //
// Date: 2/27/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-8. //

using System;

public class Scripture
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
        Console.WriteLine("To every thing there is a season, and a time to every purpose under the heaven: A time to be born, and a time to die; a time to plant, and a time to pluck up that which is planted; A time to kill, and a time to heal; a time to break down, and a time to build up; A time to weep, and a time to laugh; a time to mourn, and a time to dance; A time to cast away stones, and a time to gather stones together; a time to embrace, and a time to refrain from embracing; A time to get, and a time to lose; a time to keep, and a time to cast away; A time to rend, and a time to sew; a time to keep silence, and a time to speak; A time to love, and a time to hate; a time of war, and a time of peace.");
    }
    public list Mask()
    {
        
    }
}