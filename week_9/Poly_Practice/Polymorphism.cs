// File: Polymorphism //
// Date: 3/4/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity code in CS#. //
// Practice: Example from the assignment.


// the parent class showing the "virtual" keyword included
public abstract class Employee
{
  private string _employeeName;

  // Notice the abstract method doesn't have a body at all (not even an empty one)
  // and it is followed by a semicolon.
  public abstract float CalculatePay();
}

// a child class
public class SalaryEmployee : Employee
{
  private float salary = 100f;

  public override float CalculatePay()
  {
    return salary;
  }
}

// a child class
public class HourlyEmployee : Employee
{
  private float rate = 9f;
  private float hours = 100f;

  public override float CalculatePay()
  {
    return rate * hours; // pay is calculated differently
  }
}