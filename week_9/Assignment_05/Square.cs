// File: Square.cs //
// Date: 3/3/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Shape (Square) code in CS#. //
// Star Wars: The colors I have chosen are due my love of Star Wars.

lines (13 sloc) 283 Bytes
public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // We can observe the use of the keyword 'override' here.
    public override double GetArea()
    {
        return _side * _side;
    }
}