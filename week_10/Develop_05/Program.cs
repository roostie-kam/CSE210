// File: Program //
// Date: 3/22/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Program Activity code in CS#. //

using System;
class Program
{
    static void Main(string[] args)

    {
        string choice = "";
        int sumTotal = 0; // Point tracker.
        List<Goal> listofGoals = new List<Goal>(); // New Goal list.
        Console.Clear();

        while (choice != "0")
        Console.WriteLine(); // Open space.
        Console.WriteLine($"You've earned {sumTotal} points to your eternal goals!");
        Console.WriteLine(); // Open space.
        Console.WriteLine("List Options:");
        Console.WriteLine("1. Start New Goal");
        Console.WriteLine("2. List all Goals");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Record Data!");
        Console.WriteLine("6. Rework Data!");
        Console.WriteLine("7. Remove Data!");
        Console.WriteLine("8. Clear Data!");
        Console.WriteLine("9. End");
        Console.WriteLine("Select an option from the list:");
        choice = Console.ReadLine();

        if (choice == "1") // New goal
        {
            string choice1 = "";

            Console.WriteLine("The options are:");
            Console.WriteLine("1. Basic goal:");
            Console.WriteLine("2. Eternal goal:");
            Console.WriteLine("3. Basic goal:");
            Console.WriteLine("Which goal would you like to select?");
            choice1 = Console.ReadLine();

            if (choice1 == "1")    // Add new goal to the list.
            {

            }

        }
    }
}