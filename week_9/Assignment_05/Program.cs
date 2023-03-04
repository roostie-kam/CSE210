// File: Program.cs //
// Date: 3/3/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Shape (Program) code in CS#. //
// Star Wars: The colors I have chosen are due my love of Star Wars.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of 'Shape' objects. This means that
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape.
        // I chose the colors of Blue, Green, and Purple because of my interest in Star Wars. 
        // They're Lightsaber colors.

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Green", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // All of the shapes have a GetColor method from originating from the base class.
            string color = s.GetColor();

            // We now see that all of the shapes have a GetArea method, but their behavior is
            // unique for each shape type.
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}