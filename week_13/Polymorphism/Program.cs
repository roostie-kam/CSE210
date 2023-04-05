// File: Program //
// Date: 3/20/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Polymorphism (Program) Activity code in CS#. //

// Math Formula //

// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60
// Speed = (X/t) = where X is the distance. (minutes = time).
// Pace (min per mile or min per km) = minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed

using System;
namespace Program;

internal class NewBaseType
{
    public static T _goal { get; private set; }
}

public class T
{
}

class Program : NewBaseType
{
    private static T new_Activity;
    private static T activity_Goal;
    private static object activityGoal;
    private static T Swimming_Goal;
    private static List<T> activity;

    static void Main(string[] args, List<NewActivity> activities)
    {
        string choice = "";
        int sumTotal = 0; // Point tracker.
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("Hello and welcome to this great Physical Acitivity Adventure!");

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
            Console.WriteLine("1. Basic Activity:");
            Console.WriteLine("2. Running Activity:");
            Console.WriteLine("3. Swimming Activity:");
            Console.WriteLine("4. Cycling Activity:");
            Console.WriteLine("5.  goal:");
            Console.WriteLine("Which activity would you like to select?");
            choice1 = Console.ReadLine();

            List<T> listofActivities = NewMethod(activities);
            if (choice1 == "1")    // Add new activity (Evolving) to the list.
            {
                NewActivity newActivity = new NewActivity();
                newActivity.StartActivityEntry();
                listofActivities.Add(new_Activity);
            }

            else if (choice1 == "2") // This is the Running Activity.
            {
                ActivityGoal activityGoal = new ActivityGoal();
                activityGoal.StartActivityEntry();
                listofActivities.Add(activity_Goal);
            }

            else if (choice == "3") // This is the Swimming Activity.
            {
                SwimmingGoal swimmingGoal = new SwimmingActivity();
                swimmingGoal.StartSwimmingEntry();
                listofActivities.Add(Swimming_Goal);
            }
        }
    }

    private static List<T> NewMethod(List<NewActivity> activities) => activity; // New Activity list.

    internal class NewActivity
    {
        internal void StartActivityEntry()
        {
            throw new NotImplementedException();
        }
    }

    private class T
    {
    }
}

internal class SwimmingActivity : SwimmingGoal
{
}

internal class SwimmingGoal
{
    internal void StartSwimmingEntry()
    {
        throw new NotImplementedException();
    }
}

internal class ActivityGoal
{
    internal void StartActivityEntry()
    {
        throw new NotImplementedException();
    }
}