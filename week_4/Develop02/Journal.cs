using System;

public class Journal
{
    public List<Entry> _menu = new List<Entry>();

    public void Menu()
    {
        foreach (Entry menuTotal in _menu)
        {
            menuTotal.Display();
        }
    }
}

