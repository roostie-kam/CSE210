using System;

public class Entry
{
    public string _write;
    public string _display;
    public string _load;
    public string _save;
    public string _quit;

    public void Display()
    {
        Console.WriteLine(_write);
        Console.WriteLine(_display);
        Console.WriteLine(_load);
        Console.WriteLine(_save);
        Console.WriteLine(_quit);
    }
}