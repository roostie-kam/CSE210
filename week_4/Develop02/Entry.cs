using System;

public class Entry
{
    string prompt;
    string response;
    DateTime dateojb = DateTime.Now; 
    string date;

    public void Display()
    {
        Console.WriteLine(_write);
        Console.WriteLine(_display);
        Console.WriteLine(_load);
        Console.WriteLine(_save);
        Console.WriteLine(_quit);
    }
    public void Write()
    {
        date = dateojb.ToShortDateString();

    }
}