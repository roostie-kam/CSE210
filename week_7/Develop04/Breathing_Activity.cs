// File: Breathing Activity //
// Date: 3/12/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Breathing Activity code in CS#. //

using System.Diagnostics;
class Breathing_Activity : Activity
{
// This is the Child class of the Activity class.
// The member variables:
private int _breathing_time;
private int _remaining_seconds;
    private int _seconds;
    private ReadOnlySpan<char> breathTime;
    private int _remainingSeconds;

    public Breathing_Activity(string operationName) : base(operationName)
    {
    }
//The Methods:
private int DisplayActivityPrompt()
{
    Console.WriteLine("How many seconds would hold your breath for? ");
    string breathingTime - Console.ReadLine();
    int t = Int32.Parse(breathingTime);
    Console.WriteLine();
    _remainingSeconds - _seconds;
    GetReadyTimer(5);
    Stopwatch s - new Stopwatch();
    s.Start();

    while(s.Elapsed < TimeSpan.FromSeconds(_remaining_seconds))
    {
        Console.Write("Inhale....");
        CountDownTimer(t);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hold your breath....");
        Console.WriteLine(t);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Exhale....");
        Console.WriteLine(t);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hold your breath....");
        Console.WriteLine(t);
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}
public void RunBreathingActivity()
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Clear();
    DisplayActivityStartup();
    DisplayActivityPrompt();
    EndText();
}

    private void EndText()
    {
        throw new NotImplementedException();
    }

    private void DisplayActivityStartup()
    {
        throw new NotImplementedException();
    }
}