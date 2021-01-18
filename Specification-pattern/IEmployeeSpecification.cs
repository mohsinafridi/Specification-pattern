using System;
using System.Collections.Generic;
using System.Text;

namespace Specification_pattern
{
   public interface IEmployeeSpecification
    {
        bool IsSatisfiedBy(Employee employee);
    }
}
