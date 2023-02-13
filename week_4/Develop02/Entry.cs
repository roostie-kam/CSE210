// File: Entry //
// Date: 2/13/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Journal code in CS#. //

using System;

public class Entry
{
    string prompt;
    string response;
    DateTime dateojb = DateTime.Now; 
    string date;

    public void Display()
    {
        Console.WriteLine("write");
        Console.WriteLine("display");
        Console.WriteLine("load");
        Console.WriteLine("save");
        Console.WriteLine("quit");
    }
    public void Write()
    {
        date = dateojb.ToShortDateString();

    }
}