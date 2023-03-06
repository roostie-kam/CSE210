// File: Program.cs //
// Date: 2/27/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-8. //

using System;

public class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("save");
        Console.WriteLine("quit");
    }
    public void Write()
    {
        date = dateojb.ToShortDateString();
    }
    }
    {
        TextRemover remover = new TextRemover();
        string originalText = Scripture Test 1,2,3,34343,asdasdasd
        remover.SetOriginalText(originalText);
        string modifiedText = remover.GetModifiedText();
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
}