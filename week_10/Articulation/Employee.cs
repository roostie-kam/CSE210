// File: Employee //
// Date: 3/15/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism (Employee) Activity code in CS#. //
// Practice: Example from the assignment.
// I changed this around and did some tweaks with it to make it my own. I just used this as a template,
// to help me learn.

using System;

// The parent class.
public class Employee
{
  private float salary = 100f; // 200f etc.
 // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public float CalculatePay()
  {
    return salary;
  }
}

// The Parent class needs to show a "virtual" keyword or similar.
public class Employee
{
  private float salary = 100f;
  // The salary can have the dollar amount float to almost any dollar value and decimal point.

  public virtual float CalculatePay()
  {
    return salary;
  }
}

// This is the child class.
public class HourlyEmployee : Employee
{
  private float rate = 9f; // 8f etc.
  private float hours = 100f; // 200f etc.
 // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public override float CalculatePay()
  {
    return rate * hours; // The pay can calculated differently.
  }
}

// Create different kinds (classes) of employees....
// List<Employee> employees = new List<Employee>();
// employees.add(new Employee());
// employees.add(new HourlyEmployee());

// To get a custom calculation for each one.
// foreach(Employee employee in employees)
// {
  // float pay = employee.CalculatePay();
  // Console.WriteLine(pay);
// }

// The Parent class needs to show a "virtual" keyword or similar.
public abstract class Employee
{
  private string _employeeName;

  // We notice the abstract method doesn't have a body at all (not even an empty one)
  // and it is followed by a semicolon. ;....
  public abstract float CalculatePay();
}

// a child class
public class SalaryEmployee : Employee
{
  private float salary = 100f; // 200f etc.
  // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public override float CalculatePay()
  {
    return salary;
  }
}

// This is the child class.
public class HourlyEmployee : Employee
{
  private float rate = 9f; // 8f.
  private float hours = 100f; // 200f etc.

  public override float CalculatePay()
  {
    return rate * hours; // The pay is calculated differently here.
  }
}