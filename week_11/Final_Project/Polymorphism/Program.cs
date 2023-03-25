// File: Program //
// Date: 3/20/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Polymorphism (Program) Activity code in CS#. //

// Math Formula //

// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
//  Speed = 60 / pace
//  Pace = 60 / speed

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        // while (choice.ToSmaller() != "4")
        while (choice != "4")
        {
        // Console.BackgroundColor = ConsoleColor.DarkGreen;
        // Console.Clear();        
        Console.WriteLine("Hello Foundation4 World!");
        choice = Console.ReadLine();
        }
    }
}