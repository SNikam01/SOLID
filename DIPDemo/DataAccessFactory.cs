using System;
using System.Collections.Generic;
using System.Text;

namespace DIPDemo
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
