// File: Program //
// Date: 3/14/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Program Breathing Activity code in CS#. //

using System;

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice.ToSmaller() != "4")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("List Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Thinking Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine(". Quit");
            Console.WriteLine("Make a choice from the list:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing_Activity breathing_Activity = new Breathing_Activity("Breathing", "This activity is designed to help the user learn how to box breath, or in other words paced breathing.");
                breathing_Activity.RunBreathing_Activity();
            }
            if (choice == "2")
            {
                Reflection_Activity reflection_Activity = new Reflection_Activity("Reflection", "This exercise will assist the user to comprehend times in their life when they have been strengthened.");
                reflection_Activity.RunReflection_Activity();
            }
            if (choice == "3")
            {
                Listing_Activity listing_Activity = new Listing_Activity("Listing", "This exercise will also provide the user with an awareness of strength.");
                listing_Activity.RunListing_Activity();
            }
        }
        Console.Write("You did, Outstanding! See ya!");
    }
}