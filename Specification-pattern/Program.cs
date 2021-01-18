using Specification_pattern;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Employee employee1 = new Employee { FirstName = "Mohsin",LastName="Azam", Department = "IT", YearOfResumption = 2014 };
        Employee employee2 = new Employee { FirstName = "Ali", LastName = "Hassan", Department = "Software", YearOfResumption = 2018 };
        Employee employee3 = new Employee { FirstName = "Humaira", LastName = "Ahmad", Department = "Maths", YearOfResumption = 2018 };
        Employee employee4 = new Employee { FirstName = "Alis", LastName = "Ozil", Department = "IT", YearOfResumption = 2017 };

        Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

        Console.WriteLine("Software Department");
        List<Employee> SoftwareEmployees = GetEmployee.GetEmployeeBy(new EmployeeDepartmentSpecification("Software"), employees);
        foreach (var employee in SoftwareEmployees)
        {
            Console.WriteLine(employee.FirstName);
        }

        Console.WriteLine();

        Console.WriteLine("Employed in 2017");
        List<Employee> EmployedIn2017 = GetEmployee.GetEmployeeBy(new EmployeeYearSpecification(2017), employees);
        foreach (var employee in EmployedIn2017)
        {
            Console.WriteLine(employee.FirstName);
        }

        Console.ReadKey();

    }
}