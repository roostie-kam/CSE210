// File: Program.cs //
// Date: 2/27/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code in CS#. //

using System;

class Program
{
    static void Main(string[] args)
    {
        TextRemover remover = new TextRemover();
        string originalText = Scripture Test 1,2,3,34343,asdasdasd
        remover.SetOriginalText(originalText);
        string modifiedText = remover.GetModifiedText();
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
}