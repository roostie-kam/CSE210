// File: Program //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation (Program) Activity code in CS#. //
// namespace Program //
// namespace Encapsulation //
// using System //
// Edit/Help? //

namespace Program;
namespace Encapsulation;
using System;

// partial class Program
class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        // while (choice.ToSmaller() != "4")
        while (choice != "4")
        {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Clear();

        Order O1 = new Order();
        Console.WriteLine(O1.GetOrderString());
        Console.WriteLine(O1.GetDecimalValue());

        Order O2 = new Order(5);
        Console.WriteLine(O2.GetOrderString());
        Console.WriteLine(O2.GetDecimalValue());

        Order O3 = new Order(3, 4); 
        Console.WriteLine(O3.GetOrderString());
        Console.WriteLine(O3.GetDecimalValue());

        Order O4 = new Order(1, 3);
        Console.WriteLine(O4.GetOrderString());
        Console.WriteLine(O4.GetDecimalValue());

        // Console.WriteLine("Hello Foundation4 World!");
        choice = Console.ReadLine();
        }
    }
}