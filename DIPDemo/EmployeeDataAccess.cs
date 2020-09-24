using System;
using System.Collections.Generic;
using System.Text;

namespace DIPDemo
{
    public class EmployeeDataAccess: IEmployeeDataAccess
    {
        //EmployeeDataAccess class is the low-level module.
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Sagar",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
