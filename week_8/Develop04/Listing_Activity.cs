// File: Activity //
// Date: 3/7/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Listing Activity code in CS#. //

using System.Diagnostics;

// Listing Activity
// {
    // Variables:
       // int EntryCount()
    // Methods:
      // listCounter();
        // CountDown();
// }

class Listing_Activity : Activity

// Variables:
// {
       // int EntryCount()
// }
{
    private List<string> _activityPromptList;
    private bool _timeslip = false; // Maybe parent variable?
    private int _numberEntries;
    private int _remainingSeconds; // Maybe parent variable?

    public Listing_Activity(string operationName) : base(operationName)
    {
    }
}
// The Constructors 

// {
    // Variables:
    // string className();
    // string classInstruction();
    // int seconds();
// }
    public Listing_Activity(string activityName, string activityinstruction) : base (activityName, activityInstruction);
    {
        _activityPromptList - new List<string>() // Class list declaration.

            "What have you learned from the Savior this week?",
            "Have you helped a friend in need?",
            "How have you been a force of good this month?",
            
    }