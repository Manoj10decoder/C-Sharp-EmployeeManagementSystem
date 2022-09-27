using Employee_Management_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system.Service
{
    interface ServiceInterface
    {
        protected internal bool createEmployee(List<Employee> empList, string? empId);
        protected internal void findEmployees(List<Employee> empList);
        protected internal bool findEmployee(List<Employee> empList, string? empId);
        protected internal bool updateEmployee(List<Employee> empList, string? empId);
        protected internal bool deleteEmployee(List<Employee> empList, string? empId);
        protected internal string generateID();
    }
}
