using System;
using System.Collections.Generic;
using System.Text;

namespace DIPDemo
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
