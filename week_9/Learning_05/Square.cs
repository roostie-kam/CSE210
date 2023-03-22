using System;

using System.Diagnostics;

// lines (13 sloc) 283 Bytes
public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // We can observe the use of the keyword override here.
    public override double GetArea()
    {
        return _side * _side;
    }
}