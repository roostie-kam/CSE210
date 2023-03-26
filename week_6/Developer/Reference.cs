// File: Reference.cs //
// Date: 3/11/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation code (Scripture Memorizer) in CS#. //
// Scripture: Ecclesiastes 3:1-4. //

using System;

public class Reference
{
    private string _book = "Ecclesiastes";
    private string _chapter = "Chapter 3";
    private string _verse = "1-8";
    private string originalText;
    private string modifiedText;

    public void Display() 
    {
        // display function
        // Ecclesiastes Chapter 3:1-8.
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
}