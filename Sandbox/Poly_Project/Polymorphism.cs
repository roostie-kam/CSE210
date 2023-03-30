// File: Polymorphism //
// Date: 3/15/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism Activity code in CS#. //

// The Parent class needs to show a "virtual" keyword or similar.
public abstract class Employee
{
  private string _employeeName;
  private string _employeeID;
  // We need to realize the abstract method doesn't have to have body at all (not even an empty one),
  // and it is always followed by a semicolon. ;....
  public abstract float CalculatePay();
}

// This is the child class.
public class SalaryEmployee : Employee
{
  private float salary = 100f; // 200f etc.
  // The salary can have the dollar amount float to almost any dollar value and decimal point.

  public override float CalculatePay()
  {
    return salary;
  }
}

// This is the child class.
public class HourlyEmployee : Employee
{
  private float rate = 9f; // 8f etc.
  private float hours = 100f; // 200f etc.

  public override float CalculatePay()
  {
    return rate * hours; // The pay is calculated differently here.
  }
}