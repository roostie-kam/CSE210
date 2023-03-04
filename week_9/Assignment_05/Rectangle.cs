// File: Rectangle.cs //
// Date: 3/3/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Shape (Rectangle) code in CS#. //
// Star Wars: The colors I have chosen are due my love of Star Wars.

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // We can observe the use of the keyword 'override' here.
    public override double GetArea()
    {
        return _length * _width;
    }
}