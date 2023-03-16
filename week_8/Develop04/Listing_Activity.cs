// File: Activity //
// Date: 3/14/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Listing Activity code in CS#. //

using System.Diagnostics;

class Listing_Activity : Activity

// Listing Activity
// {
    // Variables:
       // int EntryCount;
       
    // Methods:
      // listCounter();
      // {

      // }
      // CountDown();
// }

// Variables:
{
// {
       // int EntryCount()
// }
    private List<string> _activityPromptList = new List<string> // Class list declaration. 
   {
            "What have you learned from the Savior this week?",
            "Have you helped a friend in need?",
            "How have you been a force of good this month?",
    }; 
    private bool _timeslip = false; // Maybe Child (parent) variable?
    private int _numberEntries;
    private int _remainingSeconds; // Maybe Child (parent) variable?

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