// File: Activity //
// Date: 4/4/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity code in CS#. //

namespace Activity;
using Swimming;

public class Activity : Swimming
// Activity....
{
    // Variables:
    string _activity; // Activity (_activity).
    string _swimming;
    string _distance; // Distance (_distance) - GetDistance.
    string _speed; // Speed (_pace)  
    string _laps;
    string _pace; // Pace (_speed)
    private string activity;
    private string speed;
    private string swimming;
    private string distance;
    private string laps;

    public Activity(string color, double radius) : base (color)
    {
        _activity = activity;
        _swimming = swimming;
        _distance = distance;
        _speed = speed;
        _laps = laps;
    }

    public override string GetLaps()
    {
        return _laps;
    }
    public override string GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _distance;
    }
}