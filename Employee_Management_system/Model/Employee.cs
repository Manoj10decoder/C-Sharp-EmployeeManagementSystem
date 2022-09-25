using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system.Model
{
    class Employee
    {
        private int empId;
        private string? empName;
        private int empAge;
        private string? empPhoneNumber;

        internal Employee(int empId, string? empName, int empAge, string? empPhoneNumber)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.empPhoneNumber = empPhoneNumber;
        }

        internal Employee(){ }

        public int EmployeeId { get { return empId; } set { empId = value; } }
        public string? EmployeeName { get { return empName; } set { empName = value; } }
        public int EmployeeAge { get { return empAge; } set { empAge = value; } }
        public string? EmpPhoneNumber { get { return empPhoneNumber; } set { empPhoneNumber = value; } }


        public void employeeDetails()
        {
            Console.WriteLine("|{0,-10}|{1,-15}|{2,-10}|{3,-15}|", empId, empName, empAge, empPhoneNumber);
        }

    }
}
