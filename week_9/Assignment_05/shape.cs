// File: Shape.cs //
// Date: 3/3/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Shape code in CS#. //
// Star Wars: The colors and shapes I've chosen are due my love of Star Wars.

// We need to look at the Code below about the abstract method. Because we now have an abstract 
// method, we must therefore declare an abstract class.
public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Because it doesn't make sense to define the default body for the method in the
    // base class, we make a 'near virtual' function. For example -
    //
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    //
    // Instead of declaring the function as an 'abstract' function. This means
    // that it is an empty 'virtual' function that must be executed or have  to be 'filled in' by
    // the class that inherits the Shape. Classes that have an abstract method
    // must then also be declared to be abstract.
    
    public abstract double GetArea();
}