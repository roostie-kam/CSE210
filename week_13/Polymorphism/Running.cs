// File: Running //
// Date: 4/4/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity (Running) code in CS#. //

namespace Running;
using System;
using System.Diagnostics;

// partial public class Running
// partial public class Running : Running
public abstract class Running : Activity

// Activity....
{
    // Variables:
    private string _running;
    private string _activity;
    private string activity;

    public Running(string color, double distance) : base (color)
    {
        _activity = activity;
    }

    public string GetRunning()
    {
        return _running;
    }

    public void SetActivity(string running)
    {
        _activity = activity;
    }
   public abstract double GetDistance();
}