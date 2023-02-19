// File: Prompt Generator //
// Date: 2/13/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Journal code in CS#. //

using System;

public class PromptGenerator 
{
    private List<string> _promptList = new List<string>();

    public PromptGenerator(List<string> prompts)
    {
        this._promptList = prompts;
    }
}

// Elsewhere

List<string> prompts = new List<string> {
            "Who was the most unique person that I encountered today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?"
};

PromptGenerator pg = new PromptGenerator(prompts);