// File: Program.cs //
// Date: 2/27/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-8. //

using System;
using System.Collections.Generic;

public class Program
{
    public static string ScriptureTest { get; private set; }

    static void Main(string[] args)
    {
    string.Join;
    string prompt;
    string response;
    DateTime dateojb = DateTime.Now; 
    string date;

    static void Display()
    {
        Console.WriteLine("book");
        Console.WriteLine("Chapter");
        Console.WriteLine("verse");
        Console.WriteLine("save");
        Console.WriteLine("quit");
    }

// Create a list of verses.  
        var versus = new List<string>();  
        verse.Add("1");  
        verse.Add("2");  
        verse.Add("3");  
        verse.Add("4");  
        verse.Add("5");  
        verse.Add("6");  
        verse.Add("7");  
        verse.Add("8");  

        // Iterate list element using foreach loop. 
        foreach (var country in countries)  
        {  
            Console.WriteLine(country);  
        }

    static void Write(DateTime dateojb, string date)
    {
        date = dateojb.ToShortDateString();
    }
    
    {
        TextRemover remover = new TextRemover();
        string originalText = ScriptureTest; 1,2,3,34343, asdasdasd;
        remover.SetOriginalText(originalText);
        string modifiedText = remover.GetModifiedText();
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
    }

    private class TextRemover
    {
        public TextRemover()
        {
        }

        internal void SetOriginalText(string originalText)
        {
            throw new NotImplementedException();
        }
    }
}