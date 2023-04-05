// File: Swimming //
// Date: 4/4/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity (Swimming) code in CS#. //

namespace Swimming;
using System;
using System.Diagnostics;

public class Swimming : Activity
// Activity....
{
    // Variables:
    string _rate; // 
    private string color;
    private double _distance;
    private double _lap;

    public Swimming(string color, double distance, double lap) : base (color)
    {
        _distance = distance;
        _lap = lap;
    }

    // Notice the use of the override keyword here
    public override double GetDistance()
    {
    // Distance (km) = swimming laps * 50 / 1000
        return _lap * _distance * 50 / 1000;
    }
}