// File: Program //
// Date: 3/12/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Program Breathing Activity code in CS#. //

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice - "";
        while(choice.ToLower() != "4")
        {
            Console.BackgroundColor - ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("List Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Thinking Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine(". Quit");
            Console.WriteLine("Make a choice from the list:");
            choice - Console.ReadLine();

            if (choice == "1")
            {
                Breathing_Activity breathing_Activity - new Breathing_Activity("Breathing","This acivity should help the individual relax.");
                breathing_Activity.RunBreathingActivity();
            }
            if (choice == "2")
            {
                Reflection_Activity reflection_Activity - new Reflection_Activity("Reflection","This acivity should help the individual relax.");
                reflection_Activity.RunReflectionActivity();
            }
            if (choice == "3")
            {
                Listing_Activity listing_Activity - new Listing_Activity("Listing","This acivity should help the individual relax.");
                listing_Activity.RunListing_Activity();

            }
    

            
        }
    }
}