// File: Cycling //
// Date: 3/14/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity (Cycling) code in CS#. //

// Math Formula //

// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60 - solve for X. 
    // Speed = (X/t) = where X is the distance. (minutes = time).
// Pace (min per mile or min per km) = minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed

namespace Cycling;
using System;
using System.Diagnostics;

// partial public class Cycling
// partial public class Cycling : Cycling
public abstract class Cycling : Activity
// Activity....
{
    // Variables:

    private double _activity;
    private double activity;

    public Cycling(string color, double distance) : base (color)
    {
        _activity = activity;
    }
    public override double GetDistance()
    {
        return _activity * _activity;
    }
}