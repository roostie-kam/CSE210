// File: Event //
// Date: 3/31/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Inheritance (Event) Activity code in CS#. //
// The parent class.
// Final Project //


namespace Event;
using System;
using System.Diagnostics;

// partial public class Event
// partial public class Event : Gathering
// public class Event : Gathering
// {}
public class Event
{
    private string _gatheringLocation;
    private string _gatheringName;
    private string _topic;

    public Event(string gatheringLocation, string topic)
    {
        _gatheringLocation = gatheringLocation;
        _topic = topic;
    }

    // We need to provide all of the necessary Getters and setters in order 
    // for the private member variables so they can be accessed later both 
    // outside the given class as well is inside the given class.
    public string GetGatheringName() // Indoor/Outdoor Event location. 
    {
        return _gatheringLocation;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _gatheringName + " - " + _topic;
 
   }
}