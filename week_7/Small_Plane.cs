// File: Small Plane //
// Date: 2/25/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Inheritance Activity code in CS#. //

class Plane  // base class (parent).
{
  public string brand = "Bonanza - V-tail";  // The Plane field.
  
  public void radio() // The Plane method.
  {                    
    Console.WriteLine("Squak1234, Squak1234!");
  }
}

class Plane : Plane  // The derived class (child).
{
  public string PlanemodelName = "Mustang";  // The Plane field.
}

class Program

{
  static void Main(string[] args)
  {
    // Create a myPlane object.
    Plane myPlane = new Plane();
    Plane myPlane = Vintage Plane();

    // Call the radio() method (From the Planeclass) on the myPlane object.
    myPlane.radio();

    // Display the value of the label field (from the Plane class) and the value of the PlanemodelName from the Plane class.
    Console.WriteLine(myPlane.brand + " " + myPlane.PlanemodelName);
  }
}

class Program

{
  static void Main(string[] args)
  {
    // Create a myPlane object.
    Plane myPlane = new Plane();

    // Call the radio() method (From the Plane class) on the myPlane object.
    myPlane.radio();

    // Display the value of the brand field (from the Plane class) and the value of the PlanemodelName from the Plane class.
    Console.WriteLine(myPlane.brand + " " + myPlane.PlanemodelName);
  }
}