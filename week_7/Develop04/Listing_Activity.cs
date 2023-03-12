// File: Listing_Activity.cs //
// Date: 3/12/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Activity code in CS#. //

using System.Diagnostics;

class Listing_Activity : Activity
{ //The Member Variables:
    private List<string> _activityPromptList;
    private bool _timeslip = false;
    private int _NumEntries;
    private int _remainingSeconds;

// The Constructors

    public Listing_Activity(string activityName, string activityInstruction) : base (activityName, activityInstruction);

        _activityPromptList = new List<string>();

            "How have you felt the influence of the Holy Ghost recently?",
            "Have you served the Community this month?",
            "What have you done to be a force of Good?",
            "What examples from the scriptures have helped you recently?"
}




// Activity....
// {
    // Variables:
    // string className();
    // string classInstruction();
    // int seconds();
// }

// Methods....
{
    ActivityTimer();
    GetRandomPrompt();
    DisplayNameAndInstructions();
    GetReadyTimer();
    CountDownTimer();
}

void CountDownTimer()
{
    throw new NotImplementedException();
}

void GetReadyTimer()
{
    throw new NotImplementedException();
}

void DisplayNameAndInstructions()
{
    throw new NotImplementedException();
}

void GetRandomPrompt()
{
    throw new NotImplementedException();
}

void ActivityTimer()
{
    throw new NotImplementedException();
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
        // int EntryCount()
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

