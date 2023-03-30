// File: Program //
// Date: 3/22/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Program (Polymorphism) Activity code in CS#. //

using System;

// partial class program
class Program
{
    private static Goal eternal_Goal;
    private static Goal new_Goal;

    public static Goal Agenda_Goal { get; private set; }

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
            Console.WriteLine("3.  goal:");
            Console.WriteLine("Which goal would you like to select?");
            choice1 = Console.ReadLine();

            if (choice1 == "1")    // Add new goal (Evolving) to the list.
            {
            NewGoal newGoal = new NewGoal();
            newGoal.StartGoalEntry();
            listofGoals.Add(new_Goal);
            }

            else if (choice1 == "2") // This is the Eternal Goal.
            {
                EternalGoal eternalGoal = new EternalGoal(); 
                eternalGoal.StartGoalEntry();
                listofGoals.Add(eternal_Goal);
            }

            else if (choice == "3") // This is the basic (Agenda) list of goals.
            {
                AgendaGoal agendaGoal = new AgendaGoal();
                agendaGoal.StartGoalEntry();
                listofGoals.Add(Agenda_Goal);
            }
        }
    }
}

internal class NewGoal
{
    internal void StartGoalEntry()
    {
        throw new NotImplementedException();
    }
}

internal class AgendaGoal
{
    internal void StartGoalEntry()
    {
        throw new NotImplementedException();
    }
}

internal class ChecklistGoal
{
    internal void StartGoalEntry()
    {
        throw new NotImplementedException();
    }
}

internal class EternalGoal
{
    public EternalGoal()
    {
    }

    internal void StartGoalEntry()
    {
        throw new NotImplementedException();
    }
}

internal class BasicGoal
{
    internal void StartGoalEntry()
    {
        throw new NotImplementedException();
    }
}