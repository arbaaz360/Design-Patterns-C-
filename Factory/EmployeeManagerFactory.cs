using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class EmployeeFactory
    {
        public IEmployee GetEmployee(int employeeTypeID)
        {
            IEmployee returnValue = null;
            if (employeeTypeID == 1)
            {
                returnValue = new PermanentEmployee();
            }
            else if (employeeTypeID == 2)
            {
                returnValue = new ContractEmployee();
            }
            return returnValue;
        }
    }
}
