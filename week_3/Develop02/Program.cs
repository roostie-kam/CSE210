using System;

class Program
{
    static void Main(string[] args)
    {
        //APPLIED MENU//
        Console.WriteLine("Welcome to the Journal Program!");

        Entry jou1 = new Entry();
        jou1._write = "1. Write";
        jou1._display = "2. Display";
        jou1._load = "3. Load";
        jou1._save = "4. Save";
        jou1._quit = "5. Quit";

        Journal allMenu = new Journal();
        allMenu._menu.Add(jou1);

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
        