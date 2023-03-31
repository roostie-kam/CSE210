// File: Basic //
// Date: 3/22/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a (Basic) Simple Activity code in CS#. //
// The Parent Class.

using System;
using System.Diagnostics;

// partial class BasicGoal
class Basic_Goal : Goal
{
// Variables.

// Constructors.
    public Basic_Goal()
    {} // Empty Constructor
    public Basic_Goal (string name, string description, int pointValue, bool isComplete): base  (name, pointValue, description, isComplete)
    {}
}