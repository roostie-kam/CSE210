// File: Program //
// Date: 3/15/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write a Polymorphism (Program) Activity code in CS#. //
// Practice: Example from the assignment.
// I changed this around and did some tweaks with it to make it my own. I just used this as a template,
// to help me learn.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> salary = new List<Employee>();
        SalaryEmployee s1 = new PaidEmployee("Salary", 2);
        salary.Add(s1);

        PaidEmployee s2 = new SalaryEmployee("Salary", 3, 4);
        salary.Add(s2);

        Employee s3 = new Employee("Salary", 5);
        salary.Add(s3);

        foreach (Employee e in salary)
        {
            // All of the wages have a GetWage method originating from the base class.
            string wage = s.GetWage();

            // We now see that all of the wages have a GetWage method, but their behavior is
            // unique for each wage type.
            string area = s.GetWage();

            Console.WriteLine($"The {wage} has an amount of {dollars}.");
        }
    }
}