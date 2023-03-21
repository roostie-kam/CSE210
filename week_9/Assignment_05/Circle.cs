// File: Circle.cs //
// Date: 3/3/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Shape (Circle) code in CS#. //
// Star Wars: The colors and shapes I've chosen are due my love of Star Wars.

using System;

nes (13 sloc) 305 Bytes
public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // We can observe the use of the keyword 'override' here.
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}