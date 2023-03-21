// File: Activity //
// Date: 3/14/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Activity code in CS#. //

using System;

using System.Diagnostics;

public class Activity 
// Activity....
{
    // Variables:
    string _className;
    string _classInstruction;
    int _seconds;

    public Activity(string operation_Name)
    {
        Operation_Name = operation_Name;
    }

    public string Operation_Name { get; }

    // Methods....

    public void ActivityTimer()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public void DisplayNameAndInstructions()
    {
        Console.WriteLine($"Welcome to my {_className} Activity");
        Console.WriteLine($"Welcome to my {_classInstruction} Activity");
        Console.WriteLine($"How long in seconds does it take to complete Activity");
        string choice = Console.ReadLine();
        _seconds = Int32.Parse(choice);
    }
    public void GetReadyTimer()
    {
        
    }
    public void CountDownTimer()
    {
         
    }
}
// Breathing Activity
// {    
    // Variables:
        // int breathingTime();
    //Methods:
        // BreathingPrompt();
// }

// Listing Activity
// {
    // Variables:
        // int EntryCount();
    // Methods:
        // listCounter();
        // CountDown();
// }

// Reflecting Activity
// {
    // Variables:
        // List<string>questions();
    // Methods:
       // displayRandomQuestion();
// }