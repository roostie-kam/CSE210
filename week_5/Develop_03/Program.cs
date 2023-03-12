// File: Program.cs //
// Date: 3/11/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-8. //

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private object dateojb;
    private object asdasdasd;

    public object Date { get; private set; }
    public object Test { get; private set; }

    static void Main(string[] args)
    {
        DateTime dateojb = DateTime.Now; 
    }
    public void Display()
    {
        Console.WriteLine("book");
        Console.WriteLine("Chapter");
        Console.WriteLine("verse");
        Console.WriteLine("save");
        Console.WriteLine("quit");
        Thread.Sleep(8000);
    }
    public void Write()
    {
        // DateTime = dateojb.ToShortDateString;
        Console.WriteLine("1 2 3 4 5 6 7 8");
        Console.ReadLine();        
        Console.Clear();
        Console.WriteLine("1 2 3 4 5 6 7 8");
        TextRemover remover = new TextRemover();
        string originalText = "Scripture Test 1, 2, 3, 34343, asdasdasd";
        remover.SetOriginalText(originalText);
        string modifiedText = remover.GetModifiedText();
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
}