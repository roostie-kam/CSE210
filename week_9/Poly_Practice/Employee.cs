// a parent class
public class Employee
{
  private float salary = 100f;

  public float CalculatePay()
  {
    return salary;
  }
}

// the parent class showing the "virtual" keyword included
public class Employee
{
  private float salary = 100f;

  public virtual float CalculatePay()
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

// create different kinds of employees...
List<Employee> employees = new List<Employee>();
employees.add(new Employee());
employees.add(new HourlyEmployee());

// get a custom calculation for each one
foreach(Employee employee in employees)
{
  float pay = employee.CalculatePay();
  Console.WriteLine(pay);
}

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