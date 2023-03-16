// File: Employee //
// Date: 3/15/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism (Employee) Activity code in CS#. //

// The parent class.
public class Employee
{
  private float salary = 200f; // 100f etc.
 // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public float CalculatePay()
  {
    return salary;
  }
}

// The Parent class needs to show a "virtual" keyword or similar.
public class Employee
{
  private float salary = 200f; // 100f etc.
  // The salary can have the dollar amount float to almost any dollar value and decimal point.

  public virtual float CalculatePay()
  {
    return salary;
  }
}

// This is the child class.
public class HourlyEmployee : Employee
{
  private float rate = 8f; // 9f etc.
  private float hours = 200f; // 100f etc.
 // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public override float CalculatePay()
  {
    return rate * hours; // The pay can calculated differently.
  }
}

// Create different kinds (classes) of employees....
List<Employee> employees = new List<Employee>();
employees.add(new Employee());
employees.add(new HourlyEmployee());

// To get a custom calculation for each one.
foreach(Employee employee in employees)
{
  float pay = employee.CalculatePay();
  Console.WriteLine(pay);
}

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
  private float salary = 200f; // 100f etc.
  // The salary can have the dollar amount float to almost any dollar value and deciaml point.

  public override float CalculatePay()
  {
    return salary;
  }
}

// This is the child class.
public class HourlyEmployee : Employee
{
  private float rate = 8f; // 9f.
  private float hours = 200f; // 100f etc.

  public override float CalculatePay()
  {
    return rate * hours; // The pay is calculated differently here.
  }
}