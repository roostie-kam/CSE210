// File: Prompt Generator //
// Date: 2/13/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Journal code in CS#. //

using System;

public class PromptGenerator 
{
    public List<string> _promptList = new List<string>();

    public void DisplayPrompt()
    {
        Console.Write($"What would you like to do? ");
        string toDo = Console.ReadLine();
            
        if (toDo == "1")
        {
            Random r = new Random();
            int getRandom = r.Next(0, _promptList.Count());

            Console.WriteLine(_promptList[getRandom]);
            string answer = Console.ReadLine();
        }    
    }
}