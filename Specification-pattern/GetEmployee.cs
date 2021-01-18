using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_pattern
{
    public class GetEmployee
    {
        public static List<Employee> GetEmployeeBy(IEmployeeSpecification specification, Employee[] employees)
        {
            List<Employee> NeededEmployees = new List<Employee>();


            foreach (Employee employee in employees)
            {
                if (specification.IsSatisfiedBy(employee))
                {
                    NeededEmployees.Add(employee);
                }
            }
            return NeededEmployees;
        }
    }
}
