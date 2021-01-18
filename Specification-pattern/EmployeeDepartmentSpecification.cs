using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_pattern
{
    public class EmployeeDepartmentSpecification : IEmployeeSpecification
    {
        private readonly string _department;
        public EmployeeDepartmentSpecification(string department)
        {
            _department = department;

        }

        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.Department.Equals(_department);
        }
    }
}
