// File: Program //
// Date: 2/13/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Journal code in CS#. //

using System;

class Program
{
    static void Main(string[] args)
    {
        //APPLIED MENU//
        Console.WriteLine("Welcome to the Journal Program!");
        // (Class Type) (Object Name) = new (Constructor)
        Entry jou = new Entry();
        Console.WriteLine  ("1. Write");
        Console.WriteLine  ("2. Display");
        Console.WriteLine  ("3. Load");
        Console.WriteLine  ("4. Save");
        Console.WriteLine ("5. Quit");

        Journal allMenu = new Journal();
        allMenu._menu.Add(jou);

        allMenu.Menu();

        //CREATING A LIST WITH THE QUESTIONS 
        PromptGenerator listP = new PromptGenerator();
        listP._promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?"
        };

        listP.DisplayPrompt();
    }     
}  
        